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

            public static void Beep(int hz, int time, int count)
            {
                  while ( count-- > 0 )
                  {
                        System.Console.Beep(hz, time);
                  }
            }
      }
}