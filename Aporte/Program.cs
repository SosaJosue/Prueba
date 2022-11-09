internal class Program
{
    private static void Main(string[] args)
    {
        empleadoSinHr empleadoN1 = new empleadoSinHr("martin", 40, 2.00);
        empleadoN1.imprimir();
        empleadoConHr empleadoN2 = new empleadoConHr("jose", 43, 2.00, 3);
        empleadoN2.imprimir();
        empleadoConHrTri empleadoN3 = new empleadoConHrTri("manuel", 46, 2.00, 6);
        empleadoN3.imprimir();
    }
}