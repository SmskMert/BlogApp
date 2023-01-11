import React from "react";
import {Card , Button, Container} from 'react-bootstrap';
import './category.css';

function Category({ category }) {
  let imageRef = `/categoryImages/${category.categoryUrl}.jpg`;
  return (
    <Card className="category-card-bg mt-1 d-flex justify-content-center align-items-center">
      <Card.Img className="category-image-style" src={imageRef} />
      <Card.ImgOverlay className="d-flex justify-content-center align-items-center">
        <Card.Title className="category-text display-6 fs-5">
        {category.title}
        </Card.Title>
      </Card.ImgOverlay>
    </Card>
  );
}

export default Category;
