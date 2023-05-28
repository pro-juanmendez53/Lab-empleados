using Lab_ptszona.Clases;



//PRIMERA PARTE PARA AÑADIR EMPLEADOS
//GestorEmpleados empleados = new GestorEmpleados("C:\tmp\\Empleados.Db");
//{
//    empleados.CrearTabla();


   //Empleado empleado1 = new Empleado(1,"Jefre","Palma", 18, "Administrador");
    //Empleado empleado2 = new Empleado(2,"Alan","Castillo", 19, "Supervisor");
    //Empleado empleado3 = new Empleado(3,"Jeison","Rios", 21, "Asistente");
    //Empleado empleado4 = new Empleado(4,"Jenifer","Cruz", 24, "Contador");
    //Empleado empleado5 = new Empleado(5,"Conan","Castro", 20, "Gerente");



//}



//SEGUNDA PARTE DONDE AÑADIMOS UN DATO EXTRA (SUELDO)

GestorEmpleados empleados = new GestorEmpleados("C:\\tmp\\Empleados.Db");

//    empleados.CrearTabla();

Empleado emp1 = new Empleado(1, "Jesica", "Perez", 18, "Administrador", 5000.00);
Empleado empl2 = new Empleado(2, "Angel", "Cardona", 19, "Supervisor", 7000.00);
//Empleado empl3 = new Empleado(3, "Jeni", "Salceda", 21, "Asistente", 3500.00);
//Empleado empl4 = new Empleado(4, "David", "Reyes", 24, "Contador", 5000.00);
//Empleado empl5 = new Empleado(5, "Carlos", "Rodriguez", 20, "Gerente", 9000.00);



Console.WriteLine("fin");

