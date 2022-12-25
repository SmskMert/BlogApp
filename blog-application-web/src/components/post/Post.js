import React from "react";
import {Card , Button} from 'react-bootstrap';


function Post({ post }) {
  return (
    <Card>
      <Card.Img variant="top" src="" />
      <Card.Body>
        <Card.Title>{post.title}</Card.Title>
        <Card.Text>
        {post.contents}
        </Card.Text>
        <Button variant="primary">Go somewhere</Button>
      </Card.Body>
    </Card>
  );
}

export default Post;
