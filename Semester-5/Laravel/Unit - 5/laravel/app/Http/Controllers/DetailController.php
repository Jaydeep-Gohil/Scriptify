<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;

class DetailController extends Controller
{
    public function ShowDetails(){
        $details = [
            'name' => "John Doe",
            'rollno' => 14,
            'course' => "Bsc.IT",
            'subjects' => array("PHP","MySQL","JavaScript","HTML","CSS"),
        ];
        return view('ShowDetails',compact('details'));
    }
}
