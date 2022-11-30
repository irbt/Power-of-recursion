// Given two integers, write a method that returns first number raised to the power of second number.


namespace Program{
    class PowerRecursionTask{
        public static void Main(string [] args){
            Console.Clear();
            static long ToThePowerOfRecursion(int num , int exp){
                
                 return (exp == 0 ) ? 1 : num * ToThePowerOfRecursion(num, exp-1);
            }
            Console.WriteLine(ToThePowerOfRecursion(18, 6));// → 8
            Console.WriteLine(ToThePowerOfRecursion(5, 2));// → 25
        }
    }
}