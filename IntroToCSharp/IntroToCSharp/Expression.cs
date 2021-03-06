﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToCSharp.NonGenerics
{
    abstract class Expression : IExpression
    {
        public abstract double Evaluate();
    }

    static class ExpressionExpression
    {
        public static ConstantExpression ToExpression(this double value)
        {
            return new ConstantExpression(value);
        }
    }


    sealed class ConstantExpression: Expression
    {
        private readonly double value;

        public ConstantExpression(double value)
        {
            this.value = value;
        }

        public override double Evaluate()
        {
            return value;        
        }

        public override string ToString()
        {
            return Convert.ToString(value);
        }
    }

    abstract class BinaryExpression    : Expression
    {
        protected Expression left;
        protected Expression right;

        public abstract string OperatorSymbol
        {
            get;
        }

        public override string ToString()
        {
            return left.ToString() + " " + OperatorSymbol + " " + right.ToString();
        }
    }


    class PlusExpression : BinaryExpression
    {
        public PlusExpression(Expression left, Expression right)
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

        public override double Evaluate()
        {
            return this.left.Evaluate() + this.right.Evaluate();
        }
    }

    public interface IExpression
    {
        double Evaluate(); 
    }

}
