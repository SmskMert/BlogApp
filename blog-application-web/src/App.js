import "bootstrap/dist/css/bootstrap.min.css";
import "./index.css";
import React from "react";
import Axios from "axios";
import { useState,useEffect } from "react";
import { Col, Container, Row } from "react-bootstrap";
import Categories from "./components/categories/Categories";
import Posts from "./components/posts/Posts";
import Tags from "./components/tags/Tags";
import Layout from "./pages/layout/Layout";
import Post from "./components/post/Post";
import Footer from "./components/footer/Footer";

function App() {
  const [posts, setPosts] = useState([]);
  const [categories, setCategories] = useState([]);
  const [tags, setTags] = useState([]);
  const [post, setPost] = useState(null);
  const [postsTitle, setPostsTitle] = useState("In All Categories");
  const [selectedTagName, setSelectedTagName] = useState("");
  const [selectedCategoryName, setSelectedCategoryName] = useState("");
  const getPosts = () => {
    setPost(null);
    Axios.get("https://localhost:7360/Blog/GetAllPostsWithDetails").then(
      (response) => {
        setPosts(response.data);
      }
      );
      setPostsTitle("In All Categories");
    };
    useEffect(() => {
      getPosts();
    }, []);
  const getCategories = () => {
    Axios.get("https://localhost:7360/category").then((response) => {
      setCategories(response.data);
    });
  };
  const getTags = () => {
    Axios.get("https://localhost:7360/tag").then((response) => {
      setTags(response.data);
    });
  };
  const getPost = (id) => {
    Axios.get(`https://localhost:7360/Blog/GetPostByIdWithDetails/${id}`).then(
      (response) => {
        setPost(response.data);
      }
    );
  };
  const getPostsByTagId = (id) => {
    setPost(null);
    Axios.get(`https://localhost:7360/Blog/GetPostsByTagId/${id}`).then(
      (response) => {
        setPosts(response.data);
        let postTags =response.data[0].postTags;
        let filteredPostTag = postTags.filter(postTag => {return postTag.tagId === id});
        setPostsTitle("In " + filteredPostTag[0].tag.title + " Tag");
      }
    );
  };
  const getPostsByCategoryId = (id) => {
    setPost(null);
    Axios.get(`https://localhost:7360/Blog/GetPostsByCategoryId/${id}`).then(
      (response) => {
        setPosts(response.data);
        setPostsTitle(
          "In " + response.data[0].postCategories[0].category.title
        );
      }
    );
  };
  const getTagNameById = (id) => {
    Axios.get(`https://localhost:7360/Tag/GetTagNameById/${id}`).then(
      (response) => {
        setSelectedTagName(response.data);
      }
    );
  };
  const getCategoryNameById = (id) => {
    Axios.get(`https://localhost:7360/Category/GetCategoryNameById/${id}`).then(
      (response) => {
        setSelectedCategoryName(response.data);
      }
    );
  };

  getCategories();
  getTags();

  return (
    <>
      <Layout getPosts={getPosts} />
      <Container className="mt-3">
        <Categories
          categories={categories}
          getPostsByCategoryId={getPostsByCategoryId}
          getPosts={getPosts}
        />
        <Row>
          {post ? (
            <Post post={post} getPostsByTagId={getPostsByTagId} />
          ) : (
            <Posts posts={posts} getPost={getPost} postsTitle={postsTitle} getPostsByTagId={getPostsByTagId} />
          )}
          <Tags tags={tags} getPostsByTagId={getPostsByTagId} />
        </Row>
      </Container>
      <Footer />
    </>
  );
}

export default App;
