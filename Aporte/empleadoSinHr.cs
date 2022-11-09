class empleadoSinHr:empleado
{
    public empleadoSinHr(string nombre, int horasT, double sueldoH):base(nombre, horasT, sueldoH){

    }
    public double calculoSalario (int horasT, double sueldoH){
        return(horasT*sueldoH);
    }
    public void imprimir(){
        Console.WriteLine("El empleado "+nombre+" Trabajó "+horasT+" horas, su sueldo por hora es de "+sueldoH+" y su salario es de: "+calculoSalario(horasT, sueldoH));
    }
}