import React from 'react';
import './App.css';
import { books } from './data/books';
import BookDetails from './components/BookDetails';
import BlogDetails from './components/BlogDetails';
import CourseDetails from './components/CourseDetails';

function App() {
  const courses = [
    { id: 1, name: 'Angular', date: '4/5/2021' },
    { id: 2, name: 'React', date: '6/3/2021' }
  ];

  const blogs = [
    { id: 1, title: 'React Learning', author: 'Stephen Biz', content: 'Welcome to learning React!' },
    { id: 2, title: 'Installation', author: 'Schwezdenier', content: 'You can install React from npm.' }
  ];

  return (
    <div>
      <div style={{ display: 'flex', justifyContent: 'space-around' }}>
        <CourseDetails courses={courses} />
        <BookDetails books={books} />
        <BlogDetails blogs={blogs} />
      </div>
    </div>
  );
}

export default App;
