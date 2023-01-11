import React from 'react'
import { Button } from 'react-bootstrap'

function TagButton({postTag,getPostsByTagId}) {
  return (
    <Button onClick={() => getPostsByTagId(postTag.tag.id)} className='ms-2' variant="light" size='sm'>{'#' + postTag.tag.title}</Button>
  )
}

export default TagButton