<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use App\Models\Student;

class StudentController extends Controller
{
    public function create(){
        return view('student.create');
    }
    public function Store(Request $request){
        $Student = new Student;
        $Student->name = $request->input('name');
        $Student->email = $request->input('email');
        $Student->course = $request->input('course');
        $Student->section = $request->input('section');
        $Student->save();

        return redirect()->back()->with('Status','Student Add Successfully');
    }
}
