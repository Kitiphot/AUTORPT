namespace SCG.ARS.BOI.WEB.Services
{
	public interface ILineMessageService {
		string SendNotify(string Message);
		string SendImage(System.Drawing.Image img, string message);
	}
}