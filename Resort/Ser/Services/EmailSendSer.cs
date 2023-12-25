using Resort.Models;
using Resort.Repo.IReponsitories;
using Resort.Ser.IServices;

namespace Resort.Ser.Services
{
	public class EmailSendSer : IEmailSendSer
	{
		private readonly IEmailSendRepo _emailSendRepo;
		public EmailSendSer(IEmailSendRepo emailSendRepo)
		{
			_emailSendRepo = emailSendRepo;
		}

		public Task<EmailSend> GetEmailSend()
		{
			return _emailSendRepo.GetEmailSend();
		}
	}
}
