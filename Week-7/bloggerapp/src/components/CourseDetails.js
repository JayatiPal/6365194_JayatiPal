import React from 'react';

function CourseDetails({ courses }) {
  const coursedet = (
    <ul>
      {courses.map((course) => (
        <div key={course.id}>
          <h3>{course.name}</h3>
          <p>{course.date}</p>
        </div>
      ))}
    </ul>
  );

  return (
    <div className="mystyle1">
      <h1>Course Details</h1>
      {coursedet}
    </div>
  );
}

export default CourseDetails;
