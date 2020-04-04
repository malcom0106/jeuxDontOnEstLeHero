using jeudontonestlehero.Core.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace jeudontonestlehero.Core.Data.DAO
{
    public class DaoQuestion : DaoAccess
    {
        public DaoQuestion(DefaultContext context) : base(context)
        {
        }

        public async Task<bool> AddQuestion(Question question)
        {
            bool IsValid = false;
            try
            {
                _context.Questions.Add(question);
                await _context.SaveChangesAsync();
                IsValid = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return IsValid;
        }

        public async Task<List<Question>> GetQuestions()
        {
            List<Question> questions = null;
            try
            {
                questions = await _context.Questions.ToListAsync();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return questions;
        }
    }
}
