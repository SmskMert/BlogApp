import 'bootstrap/dist/css/bootstrap.min.css';
import './index.css';
import React from 'react';
import Post from "./components/post/Post";
import Axios from 'axios';
import { useState } from 'react';

function App() {
  const[posts, setPosts] = useState([]);
  const getPosts = () => {
    Axios.get('https://localhost:7360/api/blog').then(response => {
      setPosts(response.data);
    });
  }
  getPosts();
  
  return (
    <>
 {
  posts.map(post => <Post post={post} key={post.id} />)
 }
    </>
  );
}

export default App;
