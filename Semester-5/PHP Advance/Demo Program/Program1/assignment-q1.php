<?php
	class Student{
		private $name,$rollno,$grade,$mark1,$mark2,$mark3,$total,$persentage;
		
		function __construct($nm,$rn,$mrk1,$mrk2,$mrk3){
			$this->name = $nm;
            $this->rollno = $rn;     
            $this->mark1 = $mrk1;
            $this->mark2 = $mrk2;
            $this->mark3 = $mrk3;
            
           
		}
        function getDetails(){

             $this->total = $this->mark1 + $this->mark2 + $this->mark3;
            $this->persentage = ($this->total / 300) * 100;

            echo "Name: " . $this->name . "<br>";
            echo "Roll No: " . $this->rollno . "<br>";
            echo "Grade: " . $this->grade . "<br>";
            echo "Marks 1: " . $this->mark1 . "<br>";
            echo "Marks 2: " . $this->mark2 . "<br>";
            echo "Marks 3: " . $this->mark3 . "<br>";
            echo "Total Marks: " . $this->total . "<br>";
            echo "Percentage: " . $this->persentage . "%<br>";

            if($this->persentage >= 80 || $this->persentage <= 100){
                echo "A Grade<br>";
            }
            elseif($this->persentage >= 60 && $this->persentage < 80){
                echo "B Grade<br>";
            }
            else{
                echo "C Grade<br>";
            }
    }
        function checkResult(){
            if($this->persentage >= 40 ){
                echo "Pass<br>";
            }
            else{
                echo "Failed<br>";
            }
            
        }	
	}
    $obj = new Student("John Doe", "12345", "A", 85, 90, 95);
    $obj->getDetails();
?>