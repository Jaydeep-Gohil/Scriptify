<?php
use App\Http\Controllers\DetailController;
use App\Http\Controllers\StudentController;
use Illuminate\Support\Facades\Route;

Route::get('/', function () {
    return view('welcome');
});

Route::get('/home', function () {
    return 'Hello World';
});

Route::get('/ShowDetails',[DetailController::class,'ShowDetails']);

Route::get('/get-Student',[StudentController::class,'create']);
Route::get('/add-Student',[StudentController::class,'store']);


