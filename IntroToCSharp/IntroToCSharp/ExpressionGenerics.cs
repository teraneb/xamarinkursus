using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToCSharp.Generics
{
    abstract class Expression<T>
    {
        public abstract T Evaluate();
        
    }

    static class ExpressionExpression
    {
        public static ConstantExpression<T> ToExpression<T>(this T value)
        {
            return new ConstantExpression<T>(value);
        }
    }


    sealed class ConstantExpression<T>: Expression<T>
    {
        private readonly T value;

        public ConstantExpression(T value)
        {
            this.value = value;
        }

        public override T Evaluate()
        {
            return value;        
        }

        public override string ToString()
        {
            return Convert.ToString(value);
        }
    }
    
    abstract class BinaryExpression<T>    : Expression<T>
    {
        protected Expression<T> left;
        protected Expression<T> right;

        public abstract string OperatorSymbol
        {
            get;
        }

        public override string ToString()
        {
            return left.ToString() + " " + OperatorSymbol + " " + right.ToString();
        }
    }


    class PlusExpression<T> : BinaryExpression<T>
    {
        public PlusExpression(Expression<T> left, Expression<T> right)
        {
            this.left = left;
            this.right = right;
        }

        public override string OperatorSymbol
        {
            get
            {
                return "+";
            }
        }

        public override T Evaluate()
        {
            return this.left.Evaluate() + this.right.Evaluate();
        }
    }

    public interface IExpression
    {
        double Evaluate(); 
    }
    
}