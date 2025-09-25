<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <table border="1">
        <tr>
            <th>Name</th>
            <td>{{ $details['name'] }}</td>
        </tr>
        <tr>
            <th>Roll No</th>
            <td>{{ $details['rollno'] }}</td>
        </tr>
        <tr>
            <th>Course</th>
            <td>{{ $details['course'] }}</td>
        </tr>
        <tr>
            <th>Subjects</th>
            <td>
                <ul>
                    @foreach($details['subjects'] as $subject)
                        <li>{{ $subject }}</li>
                    @endforeach
                </ul>
            </td>
        </tr>
    </table>
</body>
</html>