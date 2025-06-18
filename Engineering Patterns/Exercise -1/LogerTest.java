public class LogerTest {
    public static void main(String[]args){
     Loger l1=Loger.getInstance();
     Loger l2=Loger.getInstance();
     if(l1==l2){
        System.out.println("Both Instances are Same: ");

     }
     l1.log("Intilized Compnonets: ");
     l2.log("Database Connected: ");
      


    }
}
