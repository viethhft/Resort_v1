using Resort.Models;

namespace Resort.Ser.IServices
{
	public interface IEmailSendSer
	{
		public Task<EmailSend> GetEmailSend();
	}
}
