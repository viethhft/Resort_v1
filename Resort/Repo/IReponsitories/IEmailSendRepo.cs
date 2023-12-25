using Resort.Models;

namespace Resort.Repo.IReponsitories
{
	public interface IEmailSendRepo
	{
		public Task<EmailSend> GetEmailSend();
	}
}
