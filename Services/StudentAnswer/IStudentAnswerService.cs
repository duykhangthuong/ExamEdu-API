using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExamEdu.DB.Models;

namespace ExamEdu.Services
{
    public interface IStudentAnswerService
    {
        Task<int> InsertStudentAnswers(List<StudentAnswer> answers);
        Task<int> InsertFEStudentAnswers(List<StudentFEAnswer> answers);
    }
}