using System;
using System.Collections.Generic;

namespace Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            string roman = "MMXVIII";
            Context context = new Context(roman);

            List<Expression> tree = new List<Expression>
            {
                new ThousandExpression(),
                new HundredExpression(),
                new TenExpression(),
                new OneExpression()
            };

            foreach (Expression exp in tree)
            {
                exp.Interpret(context);
            }
            Console.WriteLine("{0} = {1}",
                roman, context.Output);

            Console.ReadKey();
        }
    }

    class Context
    {
        public Context(string input)
        {
            Input = input;
        }

        public string Input { get; set; }
        public int Output { get; set; }
    }

    abstract class Expression
    {
        public void Interpret(Context context)
        {
            if (context.Input.Length == 0)
                return;

            if (context.Input.StartsWith(Nine))
            {
                context.Output += 9 * Multiplier;
                context.Input = context.Input.Substring(2);
            }
            else if (context.Input.StartsWith(Four))
            {
                context.Output += 4 * Multiplier;
                context.Input = context.Input.Substring(2);
            }
            else if (context.Input.StartsWith(Five))
            {
                context.Output += 5 * Multiplier;
                context.Input = context.Input.Substring(1);
            }

            while (context.Input.StartsWith(One))
            {
                context.Output += 1 * Multiplier;
                context.Input = context.Input.Substring(1);
            }
        }

        public abstract string One { get; }
        public abstract string Four { get; }
        public abstract string Five { get; }
        public abstract string Nine { get; }
        public abstract int Multiplier { get; }
    }

    /// <summary>
    /// A 'TerminalExpression' class
    /// <remarks>
    /// Тысячные проверки для римской цифры М
    /// </remarks>
    /// </summary>
    class ThousandExpression : Expression
    {
        public override string One => "M";
        public override string Four => " "; 
        public override string Five => " "; 
        public override string Nine => " "; 
        public override int Multiplier => 1000; 
    }

    /// <summary>
    /// A 'TerminalExpression' class
    /// <remarks>
    /// Сотые проверки для C, CD, D или CM
    /// </remarks>
    /// </summary>
    class HundredExpression : Expression
    {
        public override string One => "C"; 
        public override string Four => "CD"; 
        public override string Five => "D"; 
        public override string Nine => "CM"; 
        public override int Multiplier => 100; 
    }

    /// <summary>
    /// A 'TerminalExpression' class
    /// <remarks>
    ///  Проверки десяток для X, XL, L и XC
    /// </remarks>
    /// </summary>
    class TenExpression : Expression
    {
        public override string One => "X"; 
        public override string Four =>  "XL"; 
        public override string Five => "L"; 
        public override string Nine => "XC"; 
        public override int Multiplier => 10; 
    }

    /// <summary>
    /// A 'TerminalExpression' class
    /// <remarks>
    /// Проверки едениц для I, II, III, IV, V, VI, VI, VII, VIII, IX
    /// </remarks>
    /// </summary>
    class OneExpression : Expression
    {
        public override string One => "I"; 
        public override string Four => "IV";
        public override string Five => "V"; 
        public override string Nine => "IX"; 
        public override int Multiplier => 1; 
    }
}
