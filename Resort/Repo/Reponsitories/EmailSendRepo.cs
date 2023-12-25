using Microsoft.EntityFrameworkCore;
using Resort.Context;
using Resort.Models;
using Resort.Repo.IReponsitories;

namespace Resort.Repo.Reponsitories
{
	public class EmailSendRepo : IEmailSendRepo
	{
		private readonly MyContext _myContext;
		public EmailSendRepo(MyContext myContext)
		{
			_myContext = myContext;
		}

		public async Task<EmailSend> GetEmailSend()
		{
			var email= await _myContext.EmailSends.FirstOrDefaultAsync();
			return email;
		}
	}
}
