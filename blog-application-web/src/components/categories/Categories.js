import React from "react";
import { Row, Col } from "react-bootstrap";
import Category from "../category/Category";
import "./categories.css";
import { Card } from "react-bootstrap";
import '../category/category.css'

function Categories({ categories, getPostsByCategoryId, getPosts }) {
  return (
    <>
      <Row>
        <h4 className="display-6 fs-2">Categories</h4>
      </Row>
      <Row>
        <Col xs={2}>
          <button className="reset-button" onClick={() => getPosts()}>
            <Card className="category-card-bg mt-1 d-flex justify-content-center align-items-center">
              <Card.Img className="category-image-style" src='categoryImages/show-all.jpg' />
              <Card.ImgOverlay className="d-flex justify-content-center align-items-center">
                <Card.Title className="category-text display-6 fs-5">
                  Show All
                </Card.Title>
              </Card.ImgOverlay>
            </Card>
          </button>
        </Col>
        {categories.map((category) => (
          <Col xs={2} key={category.id}>
            <button
              className="reset-button"
              onClick={() => getPostsByCategoryId(category.id)}
            >
              <Category category={category} key={category.id} />
            </button>
          </Col>
        ))}
      </Row>
    </>
  );
}

export default Categories;
