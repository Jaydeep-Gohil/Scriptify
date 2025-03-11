/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package exam_prectic;
import java.sql.*;


/**
 *
 * @author LENOV
 */
public class Exam_Prectic {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        try{
            Class.forName("con.mysql.jdbc.Driver");
            Connection con = DriverManager.getConnection("jdbc:mysql:///java","root","");
            String qry = "indert into form(fName,lName,Dept,Cou) values (?,?,?,?)";
            PreparedStatement pr = con.prepareStatement(qry);
            pr.setString(1,"Khushal");
            pr.setString(2,"Thummar");
            pr.setString(3,"CS & IT");
            pr.setString(4,"BSC.IT");
            pr.executeUpdate();
            System.out.println("Data Inserted....");
        }catch(Exception e){
            System.out.println("Error : "+e);
        }
    }
    
}
