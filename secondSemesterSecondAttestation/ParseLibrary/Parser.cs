using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseLibrary
{
    public class Parser
    {

        public int result { get; set; }
        private Stack<char> expressionStack { get; set; }

        public Parser(string expression)
        {
            while (expression.Contains(" "))
                expression = expression.Remove(expression.IndexOf(" "), 1); //delete all spaces
            expressionStack = new Stack<char>();
            foreach (char ch in expression) expressionStack.Push(ch);
        }

        private Parser(Stack<char> expression)
        {
            expressionStack = expression;
        }

        public bool Parse()
        {
            bool success = true;
            byte digit = 0;
            if (expressionStack.Count != 0)
            {
                success = byte.TryParse(expressionStack.Pop().ToString(), out digit);   //get last digit
            }
            else success = false;
            if (success)
            {
                this.result = (int)digit;   //set result if succes
                char next;
                if (expressionStack.Count != 0) //continue parse if smth left
                {
                    next = expressionStack.Pop();
                    Parser parser;
                    switch (next)
                    {
                        case '+':
                            parser = new Parser(expressionStack);
                            if (parser.Parse()) result += parser.result;
                            break;
                        case '-':
                            parser = new Parser(expressionStack);
                            if (parser.Parse()) result = parser.result - result;
                            break;
                        default:
                            success = false;
                            break;
                    }
                }

            }
            return success;
        }
    }
}
