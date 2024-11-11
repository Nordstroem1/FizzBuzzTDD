using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Interfaces
{
    public interface IFizzBuzz
    {
        string CombinesTheResult(int number);
        string IsFizz(int number);
        string IsBuzz(int number);
        string IsWhizz(int number);
        string IsBang(int number);
        string IsFizzBuzz(int number);
        string IsFizzBang(int number);
        string IsFizzWhizz(int number);
        string IsWhizzBang(int number);
        string IsBuzzWhizz(int number);
        string IsBuzzBang(int number);
        string IsFizzBuzzWhizz(int number);
        string IsFizzBuzzBang(int number);
        string IsFizzWhizzBang(int number);
        string IsFizzBuzzWhizzBang(int number);
    }
}
