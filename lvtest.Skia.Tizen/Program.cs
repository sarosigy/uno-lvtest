using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace lvtest.Skia.Tizen
{
	class Program
{
	static void Main(string[] args)
	{
		var host = new TizenHost(() => new lvtest.App());
		host.Run();
	}
}
}
