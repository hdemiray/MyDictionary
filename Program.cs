class Program
{
    static void Main()
    {
        MyDictionary<int, string> dayOfWeek = new MyDictionary<int, string>();

		dayOfWeek.Add(1, "Monday");
		dayOfWeek.Add(2, "Tuesday");
		dayOfWeek.Add(3, "Wednesday");
		dayOfWeek.Add(4, "Thursday");
		dayOfWeek.Add(5, "Friday");
		dayOfWeek.Add(6, "Saturday");
		dayOfWeek.Add(7, "Sunday");

		Console.Write(dayOfWeek.Count + dayOfWeek.GetValue(1));
    }
}