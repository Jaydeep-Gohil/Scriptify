/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package examprectic;
import java.sql.*;

/**
 *
 * @author LENOV
 */
public class ExamPrectic {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        
        try{
            Class.forName("com.mysql.jdbc.Driver");
            Connection con  = DriverManager.getConnection("jdbc:mysql:///java","root","");
            Statement st = con.createStatement();
            String qry = "create table exam(id int,name varchar(12))";
            st.executeUpdate(qry);
            System.out.println("Table Created...");
            
        }catch(Exception e){
            System.out.println("Error : "+e);
        }
    }
    
}
