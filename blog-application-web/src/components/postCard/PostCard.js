import React from "react";
import {Card , Button, Row, Col} from 'react-bootstrap';
import TagButton from "../tagButton/TagButton";
import './postCard.css'

function PostCard({ post, getPost,getPostsByTagId }) {
  let postImageRef = `/postImages/${post.postUrl}.png`;
  let postTags = post.postTags;
  return (
  
    <Card className="mt-3">
      <Row>
        <Col xs={4} className='d-flex'>
        <img className='post-card-image' alt={post.title} src={postImageRef} />
        </Col>
        <Col>
      <Card.Body>
        <Card.Title>{post.title}</Card.Title>
        <Card.Text>
        {post.summary}
        </Card.Text>
        <div className="d-flex justify-content-between align-items-center">
        <Button className='me-4' onClick={() => getPost(post.id)}  variant="dark">Read the Post</Button>
        <div>
        {postTags.map(postTag => <TagButton getPostsByTagId={getPostsByTagId} postTag={postTag} key={postTag.tagId} />)}
        </div>
        </div>
      </Card.Body>
      </Col>
      </Row>
    </Card>
    
  );
}

export default PostCard;
