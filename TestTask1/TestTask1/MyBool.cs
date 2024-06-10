namespace TestTask1
{
    public class MyBool
    {
        private bool _value;

        public MyBool(bool value)
        {
            _value = value;
        }

        public static bool operator == (MyBool a, bool b)
        {
            return true;
        }
        public static bool operator != (MyBool a, bool b)
        {
            return false;
        }
    }
}