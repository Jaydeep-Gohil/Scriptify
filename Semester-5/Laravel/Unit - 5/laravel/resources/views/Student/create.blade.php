<!DOCTYPE html>
<html lang="en">
<head>
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title>Student Registration Form</title>
  <style>
    body {
      font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
      background: linear-gradient(135deg, #6a11cb, #2575fc);
      height: 100vh;
      margin: 0;
      display: flex;
      justify-content: center;
      align-items: center;
    }

    .form-container {
      background: #fff;
      padding: 25px 30px;
      border-radius: 12px;
      box-shadow: 0px 8px 16px rgba(0,0,0,0.15);
      width: 350px;
    }

    .form-container h2 {
      text-align: center;
      margin-bottom: 20px;
      color: #333;
    }

    .form-group {
      margin-bottom: 15px;
    }

    .form-group label {
      font-weight: 600;
      display: block;
      margin-bottom: 6px;
      color: #444;
    }

    .form-group input, 
    .form-group select {
      width: 100%;
      padding: 10px;
      border: 1px solid #ccc;
      border-radius: 6px;
      font-size: 14px;
      transition: 0.3s;
    }

    .form-group input:focus, 
    .form-group select:focus {
      border-color: #2575fc;
      outline: none;
      box-shadow: 0 0 5px rgba(37,117,252,0.5);
    }

    .submit-btn {
      width: 100%;
      background: #2575fc;
      border: none;
      padding: 12px;
      color: white;
      font-size: 16px;
      font-weight: bold;
      border-radius: 6px;
      cursor: pointer;
      transition: background 0.3s;
    }

    .submit-btn:hover {
      background: #1a5ed8;
    }
  </style>
</head>
<body>
  <form action="{{ url('/add-Student') }}" >
    <div class="form-container">
    <h2>Student Registration</h2>
    
      <div class="form-group">
        <label for="name">Student Name</label>
        <input type="text" id="name" name="name" placeholder="Enter full name" required>
      </div>

      <div class="form-group">
        <label for="email">Email Address</label>
        <input type="email" id="email" name="email" placeholder="Enter email" required>
      </div>

      <div class="form-group">
        <label for="course">Course</label>
        <input type="text" id="course" name="course" placeholder="Enter course" required>
      </div>

      <div class="form-group">
        <label for="section">Section</label>
        <input type="text" id="section" name="section" placeholder="Enter section" required>
      </div>
  </form>
    

      <button type="submit" class="submit-btn">Register</button>
  </div>
</body>
</html>
