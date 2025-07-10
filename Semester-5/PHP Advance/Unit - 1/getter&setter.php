<?php 
	class result{
		private $mark;
		function Setmark($mrk){
			if($mrk>0 && $mrk<100){
				$this->mark=$mrk;
			}
			else{
				echo "Fail.....";
			}
		}
		function GetMark(){
			echo $this->mark;
		}
		
	}
	
	$obj = new result();
	$obj->SetMark(50);
	$obj->Getmark();
?>