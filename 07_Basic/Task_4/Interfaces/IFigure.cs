using Task_4.Interfaces;

namespace Task_4.Figures
{
	public interface IFigure
	{
		double X { get; set; }

		double Y { get; set; }

		void Draw(ICanvas canvas);

		string PicName { get; }
	}
}
