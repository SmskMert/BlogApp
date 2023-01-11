import React from "react";
import {Card , Button, Container} from 'react-bootstrap';
import './tag.css'

function Tag({ tag }) {
  let tagImageRef= `/tagImages/${tag.tagUrl}.png`;
  return (
    <Card className="tag-card-bg mt-2 d-flex justify-content-center align-items-center">
      <Card.Img className="tag-image-style" src={tagImageRef} />
      <Card.ImgOverlay className="d-flex justify-content-center align-items-center">
        <Card.Title className="tag-text display-6 fs-5">
        {'#' + tag.title}
        </Card.Title>
        
      </Card.ImgOverlay >
    </Card>
  );
}

export default Tag;
