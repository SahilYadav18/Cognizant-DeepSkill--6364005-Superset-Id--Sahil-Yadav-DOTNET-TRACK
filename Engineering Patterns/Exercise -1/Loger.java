public class Loger{
   private static Loger login;
   private  Loger(){
     System.out.println("Instance Created: ");
   }

   public static Loger getInstance(){
    if(login==null){
        login=new Loger();
    }  
    return login;
   }
   public static void log(String Message){
    System.out.println("LogedIn: "+Message);
   }

}