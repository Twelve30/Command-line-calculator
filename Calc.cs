using System;
class Functions
{
    public void add()
    {
        Console.Write("Enter the number of digits you want to add : ");
        string pi = "pi", e = "e" , mpi = "-pi" , me = "-e";
        try
        {
            uint no = uint.Parse(Console.ReadLine());
            double addno , sum = 0;
            for (uint i = 0; i < no; i++)
            {

                Console.Write("Enter no : ");
                string ano = Console.ReadLine();
                if (ano == pi)
                    {
                    addno = Math.PI;
                    }
                else if (ano == mpi)
                    {
                    addno = -1 * Math.PI;
                    }
                else if (ano == me)
                    {
                    addno = -1 * Math.E;
                    }
                else if (ano == e)
                    {
                    addno = Math.E;
                    }
                else
                    {
                    addno = double.Parse(ano);
                    }
                sum = sum + addno;
            } double sumno = sum;
            Console.WriteLine("The sum is " + sumno);
        }
        catch { Console.WriteLine("Sorry some error occurred"); }
    } 
    public void sub()
    {
        Console.Write("Enter the first number : ");
        string pi = "pi", e = "e" , mpi = "-pi" , me = "-e";
        double d, f;
        try
        {
        string inp1 = Console.ReadLine();
        if (inp1 == pi)
            {
            d = Math.PI;
            }
        else if (inp1 == e)
            {
            d = Math.E;
            }
        else if (inp1 == mpi)
            {
            d = -1 * Math.PI;
            }
        else if (inp1 == me)
            {
            d = -1 * Math.E;
            }
        else { d = double.Parse(inp1); }
            Console.Write("Enter the second number :");
            string inp2 = Console.ReadLine();
            if (inp2 == pi)
                {
                f = Math.PI;
                }
            else if (inp2 == mpi)
                {
                f = -1 * Math.PI;
                }
            else if (inp2 == me)
                {
                f = -1 * Math.E;
                }
            else if (inp2 == e)
                {
                f = Math.E;
                }
            else { f = double.Parse(inp2); }
            double subx = d - f;
            Console.WriteLine("The answer is " + subx);
        }
        catch { Console.WriteLine("Sorry some error occurred"); }
    }
    public void trunc()
    {
        Console.Write("Enter the number you want to truncate(show integer part) : ");
        string pi = "pi", e = "e" , mpi = "-pi" , me = "-e"; double no;
        try
        {
        string x = Console.ReadLine();
        if (x == pi)
            {
            no = Math.PI;
            }
        else if (x == mpi)
            {
            no = -1 * Math.PI;
            }
        else if (x == me)
            {
            no = -1 * Math.E;
            }
        else if (x == e)
            {
            no = Math.E;
            }
        else { no = double.Parse(x); }
            int tno = (int) Math.Truncate(no);
            Console.WriteLine("The answer is " + tno);
        }
        catch { Console.WriteLine("Sorry some error occurred"); }     
    }
    public void mul()
    {
        Console.Write("Enter the number of digits you want to multiply : ");
        string pi = "pi" , e = "e" , me = "-e" , mpi = "-pi";
        try
        {
            uint no = uint.Parse(Console.ReadLine());
            double addno ,  sum = 1;
            for (uint i = 0; i < no; i++)
            {
                Console.Write("Enter no : ");
                string ano = Console.ReadLine();
                if (ano == pi)
                    {
                    addno = Math.PI;
                    }
                else if (ano == mpi)
                    {
                    addno = -1 * Math.PI;
                    }
                else if (ano == me)
                    {
                    addno = -1 * Math.E;
                    }
                else if (ano == e)
                    {
                    addno = Math.E;
                    }
                else
                    {
                    addno = double.Parse(ano);
                    }
                sum *= addno;
            }
            double sumno = sum;
            Console.WriteLine("The product is " + sumno);
        }
        catch { Console.WriteLine("Sorry some error occurred"); }
    }
    public void div()
    {
        Console.Write("Enter the numerator : ");
        string pi = "pi", e = "e" , mpi = "-pi" , me = "-e"; double num, den;
        try
        {
        string x = Console.ReadLine();
        if (x == pi)
            {
            num = Math.PI;
            }
        else if (x == mpi)
            {
            num = -1 * Math.PI;
            }
        else if (x == me)
            {
            num = -1 * Math.E;
            }
        else if (x == e)
            {
            num = Math.E;
            }
        else { num = double.Parse(x); }
            Console.Write("Enter the denominator : ");
            string y = Console.ReadLine();
            if (y == pi)
                {
                den = Math.PI;
                }
            else if (y == mpi)
                {
                den = -1 * Math.PI;
                }
            else if (y == me)
                {
                den = -1 * Math.E;
                }
            else if (y == e)
                {
                den = Math.E;
                }
            else { den = double.Parse(y); }
            double ans = num / den ;
            Console.WriteLine("The answer is " + ans);
        }
        catch { Console.WriteLine("Sorry some error occurred"); }
    }
    public void rem()
    {
        Console.WriteLine("Enter the numerator : ");
        string pi = "pi", e = "e", mpi = "-pi" , me = "-e"; double num, den;
        try
        {
        string x = Console.ReadLine();
        if (x == pi)
            {
            num = Math.PI;
            }
        else if (x == e)
            {
            num = Math.E;
            }
        else if (x == me)
            {
            num = -1 * Math.E;
            }
        else if (x == mpi)
            {
            num = -1 * Math.PI;
            }
        else { num = double.Parse(Console.ReadLine()); }
        Console.WriteLine("Enter the denominator : ");
        string y = Console.ReadLine();
        if (y == pi)
            {
            den = Math.PI;
            }
        else if (y == me)
            {
            den = -1 * Math.E;
            }
        else if (y == mpi)
            {
            den = -1 * Math.PI;
            }
        else if (y == e)
            {
            den = Math.E;
            }
        else { den = double.Parse(Console.ReadLine()); }
            double rem = num % den;
            Console.WriteLine("The remainder is " + rem);
        }
        catch { Console.WriteLine("Sorry some error occurred"); }
    } 
    public void pow()
    {
        Console.Write("Enter the base : ");
        string pi = "pi", e = "e" , mpi = "-pi" , me = "-e"; double index , ba;
        try
        {
        string mn = Console.ReadLine();
        if (mn == pi)
            {
            ba = Math.PI;
            }
        else if (mn == mpi)
            {
            ba = -1 * Math.PI;
            }
        else if (mn == me)
            {
            ba = -1 * Math.E;
            }
        else { ba = double.Parse(mn); }
            Console.Write("Enter the index : ");
            string x = Console.ReadLine();
            if (x == pi)
                {
                index = Math.PI;
                }
            else if (x == mpi)
                {
                index = -1 * Math.PI;
                }
            else if (x == me)
                {
                index = -1 * Math.E;
                }
            else if (x == e)
                {
                index = Math.E;
                }
            else { index = double.Parse(x); }
            double answer = Math.Pow(ba, index);
            Console.WriteLine("The answer is " + answer);
        }
        catch { Console.WriteLine("Sorry some error occurred"); }
    }
    public void gre()
    {
        Console.WriteLine("Enter the number : ");
        string pi = "pi", e = "e" , mpi = "-pi" , me = "-e"; double x;
        try
        {
        string y = Console.ReadLine();
        if (y == pi)
            {
            x = Math.PI;
            }
        else if (y == mpi)
            {
            x = -1 * Math.PI;
            }
        else if (y == me)
            {
            x = -1 * Math.E;
            }
        else if (y == e)
            {
            x = Math.E;
            }
        else { x = double.Parse(y); }
        double n = Math.Floor(x);
        Console.WriteLine("The answer is " + n);
        }
        catch { Console.WriteLine("Sorry some error occurred"); }
    }
    public void fac(uint num)
    {        
        try
        {           
            ulong fact = 1;
            for (ulong i = 1; i <= num; i++)
            {
                fact *= i;
            }
            Console.WriteLine("The answer is " + fact);
        }
        catch { Console.WriteLine("Sorry some error occurred"); }
    }
    public void rpc()
    {
        Console.Write("Enter the x coordinate : ");
        string pi = "pi", e = "e" , mpi ="-pi" , me = "-e"; double x, y;
        try
        {
        string xc = Console.ReadLine();
        if (xc == pi)
            {
            x = Math.PI;
            }
        else if (xc == mpi)
            {
            x = -1 * Math.PI;
            }
        else if (xc == e)
            {
            x = Math.E;
            }
        else if (xc == me)
            {
            x = -1 * Math.E;
            }
        else { x = double.Parse(xc); }
            Console.Write("Enter the y coordinate : ");
            string yc = Console.ReadLine();
            if (yc == pi)
                {
                y = Math.PI;
                }
            else if (yc == mpi)
                {
                y = -1 * Math.PI;
                }
            else if (yc == me)
                {
                y = -1 * Math.E;
                }
            else if (yc == e)
                {
                y = Math.E;
                }
            else { y = double.Parse(yc); }
            double r = Math.Sqrt((x*x) + (y*y));
            double ang = Math.Atan(y / x);
            double angle = ang * (180 / Math.PI);
            Console.WriteLine("The polar coordinates are ( " + r + "," + angle + ")");
        }
        catch { Console.WriteLine("Sorry some error occurred"); }
    }
    public void prc()
    {
        Console.Write("Enter the distance of the point from origin : ");
        string pi = "pi", e = "e", mpi = "-pi", me = "-e";
        double r, ang;
        try
        {
        string dist = Console.ReadLine();
        if (dist == pi)
            {
            r = Math.PI;
            }
        else if (dist == e)
            {
            r = Math.E;
            }
        else if (dist == me)
            {
            r = -1 * Math.E;
            }
        else if (dist == mpi)
            {
            r = -1 * Math.PI;
            }
        else { r = double.Parse(dist); }
            Console.Write("Enter the angle the point makes with the x axis in anticlockwise direction : ");
            string an = Console.ReadLine();
            if (an == pi)
                {
                ang = Math.PI;
                }
            else if (an == e)
                {
                ang = Math.E;
                }
            else if (an == me)
                {
                ang = -1 * Math.E;
                }
            else if (an == mpi)
                {
                ang = -1 * Math.PI;
                }
            else { ang = double.Parse(Console.ReadLine()); }
            double angle = ang * (Math.PI/180);
            double sin = Math.Sin(angle);
            double cos = Math.Cos(angle);
            double x = r * cos;
            double y = r * sin;
            Console.WriteLine("The rectangular coordinates are ( " + x + "," + y + ")");
        }
        catch { Console.WriteLine("Sorry some error occurred"); }
    }
    public void signum()
        {
        try
            {
            Console.Write("Enter the number : ");
            string pi = "pi", e = "e", mpi = "-pi", me = "-e"; double no;
            string non = Console.ReadLine();
            if (non == pi)
                {
                no = Math.PI;
                }
            else if (non == mpi)
                {
                no = -1 * Math.PI;
                }
            else if (non == e)
                {
                no = Math.E;
                }
            else if (non == me)
                {
                no = -1 * Math.E;
                }
            else { no = double.Parse(non); }            
            int x = Math.Sign(no);
            Console.WriteLine("The sign of inputted number is " + x);
            }
        catch { Console.WriteLine("Sorry some error occurred"); }
        }
    public void lg()
    {
        Console.Write("Enter the number : ");
        string pi = "pi", e = "e", mpi = "-pi", me = "-e"; double expr;
        try
        {
        string x = Console.ReadLine();
        if (x == pi)
            {
            expr = Math.PI;
            }
        else if (x == mpi)
            {
            expr = -1 * Math.PI;
            }
        else if (x == e)
            {
            expr = Math.E;
            }
        else if (x == me)
            {
            expr = -1 * Math.E;
            }
        else { expr = double.Parse(x); }            
            double ans = Math.Log10(expr);
            Console.WriteLine("The answer is " + ans);
        }
        catch { Console.WriteLine("Sorry some error occurred"); }
    }
    public void ln()
    {
        Console.Write("Enter the number : ");
        string pi = "pi", e = "e", mpi = "-pi", me = "-e"; double exp;
        try
        {
        string x = Console.ReadLine();
        if (x == pi)
            {
            exp = Math.PI;
            }
        else if (x == mpi)
            {
            exp = -1 * Math.PI;
            }
        else if (x == e)
            {
            exp = Math.E;
            }
        else if (x == me)
            {
            exp = -1 * Math.E;
            }
        else { exp = double.Parse(x); }
            double ans = Math.Log(exp);
            Console.WriteLine("The answer is " + ans);
        }
        catch { Console.WriteLine("Sorry some error occurred"); }
    }
    public void log()
    {
        Console.Write("Enter the base : ");
        string pi = "pi", e = "e", mpi = "-pi", me = "-e"; double ba, ex;
        try
        {
            string x = Console.ReadLine();
            if (x == pi)
                {
                ba = Math.PI;
                }
            else if (x == mpi)
                {
                ba = -1 * Math.PI;
                }
            else if (x == me)
                {
                ba = -1 * Math.E;
                }
            else { ba = double.Parse(x); }
            Console.Write("Enter the index : ");
            string y = Console.ReadLine();
            if (y == pi)
                {
                ex = Math.PI;
                }
            else if (y == mpi)
                {
                ex = -1 * Math.PI;
                }
            else if (y == me)
                {
                ex = -1 * Math.E;
                }
            else if (y == e)
                {
                ex = Math.E;
                }
            else { ex = double.Parse(y); }
            double ans = Math.Log(ex, ba);
            Console.WriteLine("The answer is " + ans);
        }
        catch { Console.WriteLine("Sorry some error occurred"); }
    }
    public void lb()
        {
        Console.Write("Enter the index : ");
        string pi = "pi", e = "e", mpi = "-pi", me = "-e"; double index;
        try
            {
            string x = Console.ReadLine();
            if (x == pi)
                {
                index = Math.PI;
                }
            else if (x == mpi)
                {
                index = -1 * Math.PI;
                }
            else if (x == e)
                {
                index = Math.E;
                }
            else if (x == me)
                {
                index = -1 * Math.E;
                }
            else { index = double.Parse(x); }            
            double ans = Math.Log(index, 2);
            Console.WriteLine("The answer is " + ans);
            }
        catch { Console.WriteLine("Sorry some error occurred"); }
        }
    public void sin()
    {
        Console.Write("Enter the angle : ");
        try
        {
            double an = double.Parse(Console.ReadLine());
            double angle = an * (Math.PI / 180);
            double sine = Math.Sin(angle);
            Console.WriteLine("The sine the angle is " + sine);
        }
        catch { Console.WriteLine("Sorry some error occurred"); }
    }
    public void cos()
    {
        Console.Write("Enter the angle : ");
        try
        {
            double an = double.Parse(Console.ReadLine());
            double angle = an * (Math.PI / 180);
            double cosine = Math.Cos(angle);
            Console.WriteLine("The cosine of the angle is " + cosine);
        }
        catch { Console.WriteLine("Sorry some error occurred"); }
    }
    public void tan()
    {
        Console.Write("Enter the angle : ");
        try
        {
            double an = double.Parse(Console.ReadLine());
            double angle = an * (Math.PI / 180);
            double tangent = Math.Tan(angle);
            Console.WriteLine("The tangent of the angle is " + tangent);
        }
        catch { Console.WriteLine("Sorry some error occurred"); }
    }
    public void aln()
    {
        Console.Write("Enter the index : ");
        string pi = "pi", e = "e", me = "-e", mpi = "-pi"; double ind;
        try
        {
        string x = Console.ReadLine();
        if (x == pi)
            {
            ind = Math.PI;
            }
        else if (x == e)
            {
            ind = Math.E;
            }
        else if (x == me)
            {
            ind = -1 * Math.E;
            }
        else if (x == mpi)
            {
            ind = -1 * Math.PI;
            }
        else { ind = double.Parse(Console.ReadLine()); }
            double answer = Math.Exp(ind);
            Console.WriteLine("The answer is " + answer);
        }
        catch { Console.WriteLine("Sorry some error occurred"); }
    }
    public void alg()
    {
        Console.Write("enter the index : ");
        string pi = "pi", e = "e", me = "-e", mpi = "-pi"; double ind;
        try
        {
        string x = Console.ReadLine();
        if (x == pi)
            {
            ind = Math.PI;
            }
        else if (x == mpi)
            {
            ind = -1 * Math.PI;
            }
        else if (x == e)
            {
            ind = Math.E;
            }
        else if (x == me)
            {
            ind = -1 * Math.E;
            }
        else { ind = double.Parse(Console.ReadLine()); }
            double answer = Math.Pow(10, ind);
            Console.WriteLine("The answer is " + answer);
        }
        catch { Console.WriteLine("Sorry some error occurred"); }
    }
    public void root()
    {
        Console.Write("Enter the base : ");
        try
        {
            double ba = double.Parse(Console.ReadLine());
            Console.Write("Enter the index : ");
            double ex = double.Parse(Console.ReadLine());
            double ind = 1 / ex;
            double ans = Math.Pow(ba, ind);
            Console.WriteLine("The answer is " + ans);
        }
        catch { Console.WriteLine("Sorry some error occurred"); }
    }
    public void sinh()
        {
        try
            {
            Console.Write("Enter the angle : ");
            double ang = double.Parse(Console.ReadLine());            
            double sinang = Math.Sinh(ang);
            Console.WriteLine("The hyperbolic sin of given angle is " + sinang);
            }
        catch { Console.WriteLine("Sorry some error occurred"); }
        }
    public void cosh()
        {
        Console.Write("Enter the angle : ");
        try
            {
            double ang = double.Parse(Console.ReadLine());            
            double cosang = Math.Cosh(ang);
            Console.WriteLine("The hyperbolic cos of inputted angle is " + cosang);
            }
        catch { Console.WriteLine("Sorry some error occurred"); }
        }
    public void tanh()
        {
        Console.Write("Enter the angle : ");
        try
            {
            double ang = double.Parse(Console.ReadLine());
            double tanang = Math.Tanh(ang);
            Console.WriteLine("The hyperbolic tan of inputted angle is " + tanang);
            }
        catch { Console.WriteLine("Sorry some error occurred"); }
        }
    public void ceil()
        {
        Console.Write("Enter the number : ");
        string pi = "pi", e = "e", me = "-e", mpi = "-pi"; double no;
        try
            {
            string str = Console.ReadLine();
            if (str == e)
                {
                no = Math.E;
                }
            else if (str == me)
                {
                no = -1 * Math.E;
                }
            else if (str == pi)
                {
                no = Math.PI;
                }
            else if (str == mpi)
                {
                no = -1 * Math.PI;
                }
            else { no = double.Parse(Console.ReadLine()); }
            int x = (int) Math.Ceiling(no);
            Console.WriteLine("The answer is " + x);
            }
        catch { Console.WriteLine("Sorry some error occurred"); }
        }
    public void amean()
        {
        Console.Write("Enter the number of digits you want to find arithmetic mean of : ");
        string pi = "pi", e = "e", me = "-e", mpi = "-pi";
        try
            {
            uint no = uint.Parse(Console.ReadLine());
            double addno, sum = 0;
            for (uint i = 0; i < no; i++)
                {

                Console.Write("Enter no : ");
                string ano = Console.ReadLine();
                if (ano == pi)
                    {
                    addno = Math.PI;
                    }
                else if (ano == mpi)
                    {
                    addno = -1 * Math.PI;
                    }
                else if (ano == me)
                    {
                    addno = -1 * Math.E;
                    }
                else if (ano == e)
                    {
                    addno = Math.E;
                    }
                else
                    {
                    addno = double.Parse(ano);
                    }
                sum = sum + addno;
                } double sumno = sum;
            double avg = sumno / no;
            Console.WriteLine("The arithmetic mean is " + avg);
            }
        catch { Console.WriteLine("Sorry some error occurred"); }
        }
    public void gmean()
        {
        Console.Write("Enter the number of digits you want to find geometric mean of : ");
        string pi = "pi", e = "e", me = "-e", mpi = "-pi";
        try
            {
            uint no = uint.Parse(Console.ReadLine());
            double addno, sum = 1;
            for (uint i = 0; i < no; i++)
                {
                Console.Write("Enter no : ");
                string ano = Console.ReadLine();
                if (ano == pi)
                    {
                    addno = Math.PI;
                    }
                else if (ano == mpi)
                    {
                    addno = -1 * Math.PI;
                    }
                else if (ano == me)
                    {
                    addno = -1 * Math.E;
                    }
                else if (ano == e)
                    {
                    addno = Math.E;
                    }
                else
                    {
                    addno = double.Parse(ano);
                    }
                sum *= addno;
                }
            double sumno = sum;
            double gm = Math.Sqrt(sumno);
            Console.WriteLine("The geometric mean is " + gm);
            }
        catch { Console.WriteLine("Sorry some error occurred"); }
        }
    public void shl()
        {
        Console.Write("Enter the number : ");
        try
            {
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter the index : ");
            int y = int.Parse(Console.ReadLine());
            long ans = (long) x << y;
            Console.WriteLine("The answer is " + ans);
            }
        catch { Console.WriteLine("Sorry some error occurred"); }
        }
    public void shr()
        {
        Console.Write("Enter the number : ");
        try
            {
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter the index : ");
            int y = int.Parse(Console.ReadLine());
            long ans = (long) x >> y;
            Console.WriteLine("The answer is " + ans);
            }
        catch { Console.WriteLine("Sorry some error occurred"); }
        }
    public void frac()
        {
        Console.Write("Enter the number whose decimal part you want to find : ");
        string pi = "pi", e = "e", me = "-e", mpi = "-pi"; decimal x;
        try
            {
            string str = Console.ReadLine();
            if (str == pi)
                {
                x = (decimal) Math.PI;
                }
            else if (str == mpi)
                {
                x = (decimal) (-1 * Math.PI);
                }
            else if (str == e)
                {
                x = (decimal)Math.E;
                }
            else if (str == me)
                {
                x = (decimal) (-1 * Math.E);
                }
            else { x = decimal.Parse(str); }
            int intp = (int) decimal.Truncate(x);
            decimal decp = (decimal) x - intp;
            Console.WriteLine("The decimal part of inputted number is " + decp);
            }
        catch { Console.WriteLine("Sorry some error occurred"); }
        }
    public void perm()
        {
        Console.Write("Enter the number of objects : ");
        long x = 1, y = 1;
        try
            {
            uint n = uint.Parse(Console.ReadLine());
            Console.Write("Enter the number of objects taken at a time : ");
            uint r = uint.Parse(Console.ReadLine());
            uint me = n - r;
            for (long i = 1; i <= n; i++)
                {
                x *= i;
                }
            for (long j = 1; j <= me; j++)
                {
                y *= j;
                }
            long m = y;
            long mn = x / m;
            Console.WriteLine("The number of arrangements are " + mn);
            }
        catch { Console.WriteLine("Sorry some error occurred"); }
        }
    public void comb()
        {
        Console.Write("Enter the number of objects : ");
        long x = 1, y = 1, z = 1;
        try
            {
            uint n = uint.Parse(Console.ReadLine());
            Console.Write("Enter the number of objects taken at a time : ");
            uint r = uint.Parse(Console.ReadLine());
            uint me = n - r;
            for (long i = 1; i <= n; i++)
                {
                x *= i;
                }
            for (long j = 1; j <= r; j++)
                {
                y *= j;
                } long m = y;
            for (long k = 1; k <= me; k++)
                {
                z *= k;
                } long o = z;
            long mn = y * z;
            long ans = x / mn;
            Console.WriteLine("the number of ways of selection are " + ans);
            }
        catch { Console.WriteLine("Sorry some error occurred"); }
        }
    public void inverse()
        {
        Console.Write("Enter the number which you want to invert : ");
        string pi = "pi", e = "e", me = "-e", mpi = "-pi"; double inp;
        try
            {
            string str = Console.ReadLine();
            if (str == e)
                {
                inp = Math.E;
                }
            else if (str == me)
                {
                inp = -1 * Math.E;
                }
            else if (str == pi)
                {
                inp = Math.PI;
                }
            else if (str == mpi)
                {
                inp = -1 * Math.PI;
                }
            else { inp = double.Parse(Console.ReadLine()); }
            double x = Math.Pow(inp, -1);
            Console.WriteLine("The inverse of " + inp + " is " + x);
            }
        catch { Console.WriteLine("Sorry some error occurred"); }
        }
    public void gamma(uint x)
        {
        ulong fact = 1;
        try
            {
            for (ulong i = 1; i <= (x - 1); i++)
                {
                fact *= i;
                }
            Console.WriteLine("The answer is " + fact);
            }
        catch { Console.WriteLine("Sorry some error occurred"); }
        }
    public void abs()
        {
        Console.Write("Enter the number whose absolute value you want to find : ");
        string pi = "pi", e = "e", me = "-e", mpi = "-pi"; double y;
        try
            {
            string str = Console.ReadLine();
            if (str == pi)
                {
                y = Math.PI;
                }
            else if (str == mpi)
                {
                y = -1 * Math.PI;
                }
            else if (str == e)
                {
                y = Math.E;
                }
            else if (str == me)
                {
                y = -1 * Math.E;
                }
            else { y = double.Parse(Console.ReadLine()); }
            double x = Math.Abs(y);
            Console.WriteLine("The absolute value of " + y + " is " + x);
            }
        catch { Console.WriteLine("Sorry some error occurred"); }
        }
    public void round()
        {
        Console.Write("Enter the number you want to round : ");
        string pi = "pi", e = "e", me = "-e", mpi = "-pi"; double x;
            try {
            string str = Console.ReadLine();
            if (str == pi)
                {
                x = Math.PI;
                }
            else if (str == mpi)
                {
                x = -1 * Math.PI;
                }
            else if (str == e)
                {
                x = Math.E;
                }
            else if (str == me)
                {
                x = -1 * Math.E;
                }
            else { x = double.Parse(Console.ReadLine()); }
            Console.Write("Enter the precision(number of digits after decimal) : ");
            int pre = int.Parse(Console.ReadLine());
            int precision = Math.Abs(pre);
            double y = Math.Round(x, precision);
            Console.WriteLine("The answer is " + y);
                } catch {Console.WriteLine("Sorry some error occurred");}
        }
    public void cosec()
        {
        Console.Write("Enter angle whose : ");
        try
            {
            double an = double.Parse(Console.ReadLine());
            double x = an * (Math.PI / 180);
            double cosecx = 1 / Math.Sin(x);
            Console.WriteLine("The cosecant of inputted angle is " + cosecx);
            }
        catch { Console.WriteLine("Sorry some error occurred"); }
        }
    public void sec()
        {
        Console.Write("Enter the angle : ");
        try
            {
            double an = double.Parse(Console.ReadLine());
            double x = an * (Math.PI / 180);
            double secx = 1 / Math.Cos(x);
            Console.WriteLine("The secant of inputted angle is " + secx);
            }
        catch { Console.WriteLine("Sorry some error occurred"); }
        }
    public void cot()
        {
        Console.Write("Enter the angle : ");
        try
            {
            double an = double.Parse(Console.ReadLine());
            double x = an * (Math.PI / 180);
            double cotx = 1 / Math.Tan(x);
            Console.WriteLine("The cotangent of inputted is " + cotx);
            }
        catch { Console.WriteLine("Sorry some error occurred"); }
        }
    public void sap()
        {
        Console.Write("Enter the first term : ");
        try
            {
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter the common difference : ");
            double d = double.Parse(Console.ReadLine());
            Console.Write("Enter the number of terms : ");
            uint  n = uint.Parse(Console.ReadLine());
            double ans = (n /2) * ((2 * a) + ((n - 1) * d));
            Console.WriteLine("The answer is " + ans);
            }
        catch { Console.WriteLine("Sorry some error occurred"); }
        }
    public void sgp()
        {
        Console.Write("Enter the first term : ");
        try
            {
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter the common ratio : ");
            double r = double.Parse(Console.ReadLine());
            Console.Write("Enter the number of terms : ");
            uint n = uint.Parse(Console.ReadLine());
            if (Math.Abs(r) >= 1)
                {
                double ans = a * ((Math.Pow(r,n) - 1) / (r - 1) );
                Console.WriteLine("The answer is " + ans);
                }
            else if (Math.Abs(r) < 1)
                {
                double ans = a * ((1 - Math.Pow(r, n) - 1) / (1 - r) );
                Console.WriteLine("The answer is " + ans);
                }
            }
        catch { Console.WriteLine("Sorry some error occurred"); }
        }
}
class Mainprog
{
    public static void Main()
    {
        Functions func = new Functions();
        Console.WriteLine("This is a basic calculator program");
        Console.WriteLine("Since this program has no parser component, it doesn't accept expressions");
        Console.WriteLine("There are 4 predefined variables pi , e , -pi & -e (not available for some functions)");
        Console.WriteLine("Please enter numbers in fields of numbers only. The unit of angles is degrees & can't be changed");
        Console.WriteLine(@"The commands are
      1) add    : Addition                                    2) sub   : Subtraction
      3) mul    : Multiply                                    4) div   : Division
      5) rem    : Modulo operator                             6) pow   : Exponent
      7) rot    : Root                                        8) gre   : Greatest integer(floor) function
      9) ceil   : Ceiling function                           10) fac   : Factorial upto entered number
     11) tru    : Truncate                                   12) frac  : Fractional part
     13) rpc    : Rectangular to polar coordinate conversion 14) prc   : Polar to rectangular coordinate conversion
     15) lg     : Logarithm with base 10                     16) ln    : Logarithm with base e
     17) lb     : Logarithm with base 2                      18) npr   : Permutations
     19) ncr    : Combinations                               20) sgn   : Signum (sign) function
     21) log    : Logarithm with entered base                22) alg   : Antilogarithm with base 10
     23) aln    : Antilogarithm with base e                  24) sin   : Sine function
     25) cos    : Cosine function                            26) tan   : Tangent function
     27) sinh   : Hyperbolic Sine function                   28) cosh  : Hyperbolic Cosine function
     29) tanh   : Hyperbolic Tangent function                30) cosec : Cosecant function
     31) secant : Secant function                            32) cot   : Cotangent function
     33) amean  : Arithmetic mean                            34) gmean : Geometric mean
     35) shl    : Arithmetic left shift                      36) shr   : Arithmetic right shift
     37) inv    : Inverse of a number                        38) gamma : Extensions of factorials [=(x-1)!]
     39) mod    : Absolute value                             40) round : Rounding
     41) sap    : Sum of terms of AP                         42) sgp   : Sum of terms of GP
     43) pi     : Value of pi                                44) e     : Value of e (Euler's constant)
     45) help   : Show the commands                          46) exit  : Exit the program");
        string a = "add", s = "sub", m = "mul", d = "div", p = "pow", f = "rem", g = "gre", lg = "lg", ln = "ln", log = "log" , amean = "amean" , gmean = "gmean" , npr = "npr" , ncr = "ncr" , cosec = "cosec" , sec = "sec" , cot = "cot";
        string sin = "sin", cos = "cos", tan = "tan" , bye = "exit" , alg = "alg" , aln = "aln" , rot = "rot" , help = "help" , fac = "fac" , shl = "shl" , shr = "shr" , abs = "mod" , round = "round" , lb = "lb" , e = "e" , pi = "pi";
        string rpc = "rpc", prc = "prc" , tru = "tru" , sgn = "sgn" , sinh = "sinh" , cosh = "cosh" , tanh = "tanh" , ceil = "ceil" , frac = "frac" , inv = "inv" , gamma = "gamma" , sap = "sap" , sgp = "sgp";
        for (; ; )
        {
            string input = Console.ReadLine();
            if (a == input)
            {
                func.add();
            }
            else if (e == input)
            {
                Console.WriteLine("the value of e (Euler's constant) is " + Math.E);
            }
            else if (pi == input)
            {
                Console.WriteLine("The value of pi is " + Math.PI);
            }
            else if (s == input)
            {
                func.sub();
            }
            else if (m == input)
            {
                func.mul();
            }
            else if (fac == input)
            {
                Console.WriteLine("Enter the number upto which you want to find the factorial");
                uint x = uint.Parse(Console.ReadLine());
                func.fac(x);
            }
            else if (sinh == input)
            {
                func.sinh();
            }
            else if (cosh == input)
            {
                func.cosh();
            }
            else if (tanh == input)
            {
                func.tanh();
            }
            else if (d == input)
            {
                func.div();
            }
            else if (f == input)
            {
                func.rem();
            }
            else if (p == input)
            {
                func.pow();
            }
            else if (cosec == input)
            {
                func.cosec();
            }
            else if (sec == input)
            {
                func.sec();
            }
            else if (cot == input)
            {
                func.cot();
            }
            else if (sgn == input)
            {
                func.signum();
            }
            else if (lb == input)
            {
                func.lb();
            }
            else if (g == input)
            {
                func.gre();
            }
            else if (ceil == input)
            {
                func.ceil();
            }
            else if (round == input)
            {
                func.round();
            }
            else if (abs == input)
            {
                func.abs();
            }
            else if (gamma == input)
            {
            Console.WriteLine("Enter the index");
            uint num = uint.Parse(Console.ReadLine());
                func.gamma(num);
            }
            else if (lg == input)
            {
                func.lg();
            }
            else if (ln == input)
            {
                func.ln();
            }
            else if (sgp == input)
            {
                func.sgp();
            }
            else if (log == input)
            {
                func.log();
            }
            else if (tru == input)
            {
                func.trunc();
            }
            else if (sap == input)
            {
                func.sap();
            }
            else if (frac == input)
            {
                func.frac();
            }
            else if (sin == input)
            {
                func.sin();
            }
            else if (rpc == input)
            {
                func.rpc();
            }
            else if (inv == input)
            {
                func.inverse();
            }
            else if (prc == input)
            {
                func.prc();
            }
            else if (cos == input)
            {
                func.cos();
            }
            else if (tan == input)
            {
                func.tan();
            }
            else if (bye == input) { break; }
            else if (aln == input)
            {
                func.aln();
            }
            else if (alg == input)
            {
                func.alg();
            }
            else if (amean == input)
            {
                func.amean();
            }
            else if (gmean == input)
            {
                func.gmean();
            }
            else if (shl == input)
            {
                func.shl();
            }
            else if (shr == input)
            {
                func.shr();
            }
            else if (rot == input)
            {
                func.root();
            }
            else if (npr == input)
            {
                func.perm();
            }
            else if (ncr == input)
            {
                func.comb();
            }
            else if (help == input)
            {
            Console.WriteLine(@"The commands are
      1) add    : Addition                                    2) sub   : Subtraction
      3) mul    : Multiply                                    4) div   : Division
      5) rem    : Modulo operator                             6) pow   : Exponent
      7) rot    : Root                                        8) gre   : Greatest integer(floor) function
      9) ceil   : Ceiling function                           10) fac   : Factorial upto entered number
     11) tru    : Truncate                                   12) frac  : Fractional part
     13) rpc    : Rectangular to polar coordinate conversion 14) prc   : Polar to rectangular coordinate conversion
     15) lg     : Logarithm with base 10                     16) ln    : Logarithm with base e
     17) lb     : Logarithm with base 2                      18) npr   : Permutations
     19) ncr    : Combinations                               20) sgn   : Signum (sign) function
     21) log    : Logarithm with entered base                22) alg   : Antilogarithm with base 10
     23) aln    : Antilogarithm with base e                  24) sin   : Sine function
     25) cos    : Cosine function                            26) tan   : Tangent function
     27) sinh   : Hyperbolic Sine function                   28) cosh  : Hyperbolic Cosine function
     29) tanh   : Hyperbolic Tangent function                30) cosec : Cosecant function
     31) secant : Secant function                            32) cot   : Cotangent function
     33) amean  : Arithmetic mean                            34) gmean : Geometric mean
     35) shl    : Arithmetic left shift                      36) shr   : Arithmetic right shift
     37) inv    : Inverse of a number                        38) gamma : Extensions of factorials [=(x-1)!]
     39) mod    : Absolute value                             40) round : Rounding
     41) sap    : Sum of terms of AP                         42) sgp   : Sum of terms of GP
     43) pi     : Value of pi                                44) e     : Value of e (Euler's constant)
     45) help   : Show the commands                          46) exit  : Exit the program");
            }
            else continue;
           }
            
        }
    }