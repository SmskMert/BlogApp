import React from "react";
import { Col } from "react-bootstrap";
import "./post.css";
import TagButton from "../tagButton/TagButton";

function Post({ post, getPostsByTagId }) {
  let postImageRef = `/postImages/${post.postUrl}.png`;
  let postTags = post.postTags;
  let postCategories = post.postCategories;
  return (
    <Col xs={9}>
      <h4 className="display-6 fs-1 mt-4">{post.title}</h4>
      <img
        className="post-card-image mb-2 post-main-image"
        alt={post.title}
        src={postImageRef}
      />

      <div>{post.contents}</div>
      <hr />
      <div className="d-flex align-items-center justify-content-between">
        <div className="m-2">
          <span className="fw-bold">Category: </span>
          {postCategories.map((postCategory) => (
            <span>{postCategory.category.title}</span>
          ))}
        </div>

        <div className="m-2">
          {postTags.map((postTag) => (
            <TagButton postTag={postTag} getPostsByTagId={getPostsByTagId} key={postTag.tagId} />
          ))}
        </div>
      </div>
      <hr />

    </Col>
  );
}

export default Post;
