using System.Collections.Generic;

namespace Lab2
{
    public class Green
    {
        const double E = 0.0001;
        const double Da = 0.0000000001;
        public double Task1(int n)
        {
            double answer = 0;

            // code here
            for (int i = 2; i <= n; i += 2)
            {
                answer += (double)i / (i + 1);
            }
            // end

            return answer;
        }
        public double Task2(int n, double x)
        {
            double answer = 0;

            // code here
            double term = 0;
            for (int i = 0; i <= n; i++)
            {
                answer += term;
                term /= x;
            }
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            long factorial = 1;
            for (int i = 0; i <= n; i++)
            {
                if (i > 0) factorial *= i;
                answer += factorial;
            }
            // end

            return answer;
        }
        public double Task4(double x)
        {
            double answer = 0;

            // code here
            double term = 1;
            int n = 1;
            double epsilon = 1e-4;
             while (Math.Abs(term) >= epsilon)
            {
                term = Math.Sin(n * Math.Pow(x, n));
                answer += term;
                n++;
            }
            // end

            return answer;
        }
        public int Task5(double x)
        {
            int answer = 0;

            // code here
            int n = 1;
            double prev = 1.0 / x;
            double current = 1.0 / (x * x);
            while (Math.Abs(current - prev) >= 1e-4)
            {
                n++;
                prev = current;
                current /= x;
            }
            answer = n;
            // end

            return answer;
        }
        public int Task6(int limit)
        {
            int answer = 0;

            // code here
            int elem = 1, i = 0;

            if (elem < limit)
            {
                elem *= 2;
                answer += elem;
                i++;
            }
            if (elem > limit)
            {
                return answer;
            }
            // end

            return answer;
        }

        public int Task7(double L)
        {
            int answer = 0;

            // code here
            double atomDiameter = 1e-10;
            while (L > atomDiameter)
            {
                L /= 2;
                answer++;
            }
            // end

            return answer;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here

            // end

            return (SS, SY);
        }
    }
}
