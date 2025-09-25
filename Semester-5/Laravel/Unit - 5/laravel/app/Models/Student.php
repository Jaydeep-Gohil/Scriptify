<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Model;

class Student extends Model
{
    protected $table = 'Students';
    protected $fillLable = ['name','email','course','section'];
}
