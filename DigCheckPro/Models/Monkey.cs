namespace DigCheckPro
{
    public class Monkey
	{
		public string Name {get;set;}
		public string Location { get; set; }
		public string Details { get; set; }

		public override string ToString ()
		{
			return Name;
		}
	}
}

