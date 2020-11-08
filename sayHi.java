// interface iGreet
// {
// 	public void greet();
// }
// class Hi implements iGreet
// {
// 	public void greet()
// 	{
// 		System.out.println("Hi");
// 	}
// 	public static void main(String args[])
// 	{
// 		iGreet obj = new Hi();
// 		obj.greet();
// 	}
// }

// interface Pet
// {
//   public void test();
// }
// class Dog implements Pet
// {
//    public void test()
//    {
//      System.out.println("Interface Method Implemented");
//    } 
//    public static void main(String args[])
//    {
//      Pet p = new Dog();
//      p.test();
//  	}
// }

interface iGreet
{
  public void greet();
}
class Hi implements iGreet
{
   public void greet()
   {
     System.out.println("Interface Method Implemented");
   } 
   public static void main(String args[])
   {
     iGreet obj = new Hi();
     obj.greet();
 	}
}