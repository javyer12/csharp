using static System.Console;

namespace CoreSchool.Util
{
      public static class Printer
      {
            public static void  DrawLine(int len=10)
            {
                 WriteLine("".PadLeft(len,'-'));
            }

            public static void  PressEnter()
            {
                 WriteLine("Press Enter to continue");
            }
             public static void  WriteTitle(string title)
            {
                  var leng = title.Length + 4;
                  DrawLine(leng);
                  WriteLine($"| {title} |");
                  DrawLine(leng);
            }

            public static void Beep(int hz = 2000, int time = 500, int count = 1)
            {
                  while ( count-- > 0 )
                  {
                        System.Console.Beep(hz, time);
                  }
            }
      }
}