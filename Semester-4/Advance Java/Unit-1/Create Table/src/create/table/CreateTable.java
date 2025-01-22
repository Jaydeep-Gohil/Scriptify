/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package create.table;
import java.sql.*;
/**
 *
 * @author LENOV
 */
public class CreateTable {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        try {
            Class.forName("com.mysql.jdbc.Driver");
            Connection con = DriverManager.getConnection("jdbc:mysql:///java","root","");
            Statement st =con.createStatement();
            String str ="create table first ("
                    + "name varchar(15)"
                    + "rollno number)";
            st.executeUpdate(str);
            System.out.println("Table Created...");
            
        } catch (Exception e) {
            System.out.println("Error : "+e);
        }
    }
    
}
;