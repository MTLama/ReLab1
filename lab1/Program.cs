using System.Diagnostics.CodeAnalysis;

double parallelogramSide, parallelogramHight, parallelogramArea, triangleHight, triangleBase, triangleArea, 
    enterParametr, pyramidHight, pyramidPerimetr, pyramidLateralSurfaceArea, pyramidSideLenght, pyramidVolume, sphereRadius;
Console.WriteLine("this lab is made by Sergy Zaika");

Console.WriteLine("why are u here?\n");

while (true)
{
    Console.WriteLine(
    "1) calculate the area of the parallelogram;\r\n" +
    "2) calculate the area of the triangle using Heron's formula;\r\n" +
    "3) calculate the area of the lateral surface of the pyramid;\r\n" +
    "4) calculate the volume of the pyramid;\r\n" +
    "5) calculate the volume of the sphere.\r\n" +
    "6) nah im done for today");
    enterParametr = Convert.ToDouble(Console.ReadLine());


    if (enterParametr == 1)
    {

        Console.WriteLine("uve chosed area of the parallelogram\r\n" + 
            "Formula is S = b*h, so please enter yr side and hight");
        parallelogramSide = Convert.ToDouble(Console.ReadLine());
        parallelogramHight = Convert.ToDouble(Console.ReadLine());

        if (parallelogramSide == 0  ||  parallelogramHight == 0) {Console.WriteLine("Am I a joke for u? Why ever somebody needs computer for this? Its just " + 0 + "\r\n" +"What else?");}
        if (parallelogramSide < 0 || parallelogramHight < 0) { Console.WriteLine("I think uve made a mistake, anyway im not going to calculate this, sry. Please enter positive volume less then " + Double.MaxValue); }

        if (parallelogramSide > 0 && parallelogramHight > 0)
        {
            parallelogramArea = parallelogramSide * parallelogramHight;
            Console.WriteLine("Calculating, bip, bop\r\n" +
                "Here u go: area equals to " + parallelogramArea + "\r\n" +
                "What else?");
        }
    }

    if (enterParametr == 2)
    {
        Console.WriteLine("uve chosed area of the triangle using Heron's formula\r\n" +
            "Formula is S = h*b/2 so please enter yr hight and  base of that hight ");
        triangleHight = Convert.ToDouble(Console.ReadLine());
        triangleBase = Convert.ToDouble(Console.ReadLine());

        if (triangleHight == 0 || triangleBase == 0) { Console.WriteLine("Am I a joke for u? Why ever somebody needs computer for this? Its just " + 0 + "\r\n" + "What else?"); }
        if (triangleHight < 0 || triangleBase < 0) { Console.WriteLine("I think uve made a mistake, anyway im not going to calculate this, sry. Please enter positive volume less then " + Double.MaxValue); }

        if (triangleHight > 0 && triangleBase > 0)
        {
            triangleArea = triangleHight * triangleBase / 2;
            Console.WriteLine(triangleArea + "? " + "IDK something like that..." + "\r\n" +
                "What else?");
        }
    }

    if (enterParametr == 3)
    {
        Console.WriteLine("uve chosed area of the lateral surface of the pyramid\r\n" +
           "Formula is S = P*l/2 so please enter yr hight of lateral surface and  perimetr  ");
        pyramidHight = Convert.ToDouble(Console.ReadLine());
        pyramidPerimetr = Convert.ToDouble(Console.ReadLine());

        if (pyramidHight == 0 || pyramidPerimetr == 0) { Console.WriteLine("Am I a joke for u? Why ever somebody needs computer for this? Its just " + 0 + "\r\n" + "What else?"); }
        if (pyramidHight < 0 || pyramidPerimetr < 0) { Console.WriteLine("I think uve made a mistake, anyway im not going to calculate this, sry. Please enter positive volume less then " + Double.MaxValue); }

        if (pyramidHight > 0 && pyramidPerimetr > 0)
        {
            pyramidLateralSurfaceArea = pyramidHight * pyramidPerimetr / 2;
            Console.WriteLine("woha, its " + pyramidLateralSurfaceArea + " Did u know? " + "\r\n" +
                "What else?");
        }
    }
    
    if (enterParametr == 4)
    {
        Console.WriteLine("uve chosed volume of the pyramid\r\n" +
          "Formula is V = (b^2)*h/3 so please enter yr hight of piramid and side length of the base");
        pyramidHight = Convert.ToDouble(Console.ReadLine());
        pyramidSideLenght = Convert.ToDouble(Console.ReadLine());

        if (pyramidHight == 0 || pyramidSideLenght == 0) { Console.WriteLine("Am I a joke for u? Why ever somebody needs computer for this? Its just " + 0 + "\r\n" + "What else?"); }
        if (pyramidHight < 0 || pyramidSideLenght < 0) { Console.WriteLine("I think uve made a mistake, anyway im not going to calculate this, sry. Please enter positive volume less then " + Double.MaxValue); }

        if (pyramidHight > 0 && pyramidSideLenght > 0)
        {
            pyramidVolume = pyramidHight * (double)Math.Pow(pyramidSideLenght, 2) / 2;
            Random rnd = new Random();
            int num = rnd.Next(128);
            Console.WriteLine("Its  " + num + "  " + "\r\n" +
                "What el..." + "\r\n" +
                "Oh weight, i said   " + num + "? Sry, ur answer is " + pyramidVolume + "\r\n" +
                "What else?" + "\r\n");
        }
    }

    if (enterParametr == 5)
    {
        Console.WriteLine("uve chosed volume of the sphere\r\n" +
            "Formula is V = (4/3)*pi*r^3 so please enter yr radius");
        sphereRadius = Convert.ToDouble(Console.ReadLine());
        double pi = Math.PI;

        if (sphereRadius == 0) { Console.WriteLine("Am I a joke for u? Why ever somebody needs computer for this? Its just " + 0 + "\r\n" + "Maybe try smth else?"); }
        if (sphereRadius < 0) { Console.WriteLine("I think uve made a mistake, anyway im not going to calculate this, sry. Please enter positive volume less then " + Double.MaxValue); }

        if (sphereRadius > 0) { 
        pyramidLateralSurfaceArea = 4 * pi * (double)Math.Pow(sphereRadius, 3) / 3;
        Console.WriteLine("Dios, ¿por qué estoy haciendo esto? Odio mi trabajo... Here u go " + pyramidLateralSurfaceArea + "\r\n" +
            "What else?"); }

    }

    if (enterParametr == 6)
    {
        Console.WriteLine("ok bye");
        break;
    }
}
 
