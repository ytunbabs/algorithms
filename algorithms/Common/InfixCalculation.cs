using System;
using Abstractions.Stack.Interfaces;
using Abstractions.Stack;
namespace CommonAlgorithms
{
    public class InfixCalculation
    {
        //private Stack<string> _stack;

        public InfixCalculation()
        {
            
        }

        public int Calculate(string expression)
        {
            if (string.IsNullOrEmpty(expression))
            {
                throw new Exception("Invalid input/expression Exception");
            }

            var postFixExpression = InfixToPostFix(expression);
            

            var solutionStack = new Abstractions.Stack.Stack<string>(postFixExpression.Length);

            

            int expressionValue = 0;
            int topValue;
            int bottomValue;

            for(int i=0; i< postFixExpression.Length; i++)
            {
                string currentChar = postFixExpression[i].ToString();

                if (!"*/-+".Contains(currentChar.Trim()))
                {
                    solutionStack.Push(currentChar);

                }
                else
                {
                    switch (currentChar)
                    {
                        case "+":
                            expressionValue = int.Parse(solutionStack.Pop()) + int.Parse(solutionStack.Pop());
                            solutionStack.Push(expressionValue.ToString());
                            break;
                        case "*":
                            expressionValue = int.Parse(solutionStack.Pop()) * int.Parse(solutionStack.Pop());
                            solutionStack.Push(expressionValue.ToString());
                            break;
                        case "/":
                            topValue = int.Parse(solutionStack.Pop());
                            bottomValue = int.Parse(solutionStack.Pop());
                            expressionValue = bottomValue / topValue;
                            solutionStack.Push(expressionValue.ToString());
                            break;
                        case "-":
                            topValue = int.Parse(solutionStack.Pop());
                            bottomValue = int.Parse(solutionStack.Pop());
                            expressionValue = bottomValue - topValue;
                            solutionStack.Push(expressionValue.ToString());
                            break;

                        default: break;

                    }

                    
                }
            }

            return expressionValue;

        }

        private string InfixToPostFix(string infixExpression)
        {
            var operatorStack = new Abstractions.Stack.Stack<string>(infixExpression.Length);
            var postFixStack = new System.Collections.Generic.Stack<string>(infixExpression.Length);

            string currentOperator = string.Empty;

            for(int i=0; i<infixExpression.Length; i++)
            {
                string currentValue = infixExpression[i].ToString();
                if(currentValue == "(")
                {
                    continue;
                }
                else if(currentValue == ")")
                {
                    postFixStack.Push(operatorStack.Pop());
                }
                else if ("*/-+".Contains(currentValue))
                {
                    operatorStack.Push(currentValue);
                }
                else
                {
                    postFixStack.Push(currentValue);
                }
            }
            
            string[] postFix = postFixStack.ToArray();
            int length = postFix.Length;

            for (int i = 0, j = length - 1; i < length; i++, j--)
            {
                string temp = postFix[i];
                postFix[i] = postFix[j];
                postFix[j] = temp;

                length -= 1;
            }

            return string.Join("", postFix);
        }
    }
}
