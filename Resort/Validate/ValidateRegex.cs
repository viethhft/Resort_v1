using System.Security.Cryptography;
using System.Text;

namespace Resort.Validate
{
	public class ValidateRegex
	{
		public static string ReversePass(string password)
		{
			byte[] pass_byte = ASCIIEncoding.ASCII.GetBytes(password);//dịch pass ra dạng bytes theo bảng mã ASCII
			MD5 mD5 = MD5.Create();

			var haspass = mD5.ComputeHash(pass_byte);//chuyển mảng bytes vừa dịch ra thành mảng bytes khác bằng md5
			string savehas = "";

			foreach (var item in haspass)
			{
				//chuyển dạng bytes về chuỗi để đảo ngược dãy bytes
				savehas += item;
			}

			char[] term = savehas.ToCharArray();
			Array.Reverse(term);//hàm đảo ngược
			string new_haspasscode = new string(term);// đưa về dạng chuỗi sau khi đảo

			pass_byte = ASCIIEncoding.ASCII.GetBytes(new_haspasscode);//tiếp tục chuyển sang bytes
			haspass = mD5.ComputeHash(pass_byte);//tiếp tục dùng md5 phân nhỏ
			savehas = "";
			foreach (var item in haspass)
			{
				savehas += item;
			}

			char[] chars = savehas.ToCharArray();//đưa về mảng char
												 //mảng char theo ascii công thức: char+ vị trí chính nó + char vị trí liền kề %2
			var char_reverse = chars.Select((value, index) => new { value, index }).ToArray();
			var finish = char_reverse.Select(c => c.value + c.index + (char_reverse.Length > c.index + 1 ? char_reverse[c.index + 1].value % 2 : char_reverse[c.index / 2].value % 2)).Select(c => (char)c).ToArray();
			string new_char = new string(finish);
			foreach (var item in char_reverse)//đưa về dạng chuỗi trả ra kết quả
			{
				new_char += item.value;
			}

			return new_char;
		}

	}
}
