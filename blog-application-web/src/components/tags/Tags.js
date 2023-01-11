import React from "react";
import {Col, Row} from 'react-bootstrap';
import Tag from "../tag/Tag";
import './tags.css'

function Tags({ tags,getPostsByTagId }) {
  return (
    <Col xs={3}>
    <Row>
      <h4 className="mt-4 display-6 fs-2">Tags</h4>
    </Row>
    {tags.map((tag) => (
      <Row key={tag.id}>
        <button className="reset-button" onClick={() => getPostsByTagId(tag.id)} >
        <Tag tag={tag} key={tag.id} />
        </button>
      </Row>
    ))}
  </Col>
  );
}

export default Tags;
