import React from 'react'
import NavBar from '../../components/navbar/NavBar'

function Layout({getPosts}) {
  return (
    <NavBar getPosts={getPosts} />
  )
}

export default Layout