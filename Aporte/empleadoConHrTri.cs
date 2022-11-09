class empleadoConHrTri:empleado
{
    public int horasEx {get; set;}

    public empleadoConHrTri(string nombre, int horasT, double sueldoH, int horasEx):base(nombre, horasT, sueldoH){
        this.horasEx = horasEx;
    }

    public double calculoSalario(int horasT, double sueldoH, int horasEx)
    {
        double sueldoHE;
        double extra;
        extra = horasEx*sueldoH;
        sueldoHE = horasT*sueldoH;

        return(extra+sueldoHE);
    }
    public void imprimir(){
        Console.WriteLine("El empleado "+nombre+" Trabajó "+horasT+" horas, su sueldo por hora es de "+sueldoH+" y su salario es de: "+calculoSalario(horasT, sueldoH,horasEx));
    }
}