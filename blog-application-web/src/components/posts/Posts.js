import React from "react";
import { Col } from "react-bootstrap";
import PostCard from "../postCard/PostCard";

function Posts({ posts, getPost, postsTitle,getPostsByTagId }) {
  return (
    <Col xs={9}>
      <h4 className="mt-3 display-6">{'Posts ' + postsTitle}</h4>
      <div>
        {posts.map((post) => (
          <PostCard post={post} getPostsByTagId={getPostsByTagId} getPost={getPost} key={post.id} />
        ))}
      </div>
    </Col>
  );
}

export default Posts;
