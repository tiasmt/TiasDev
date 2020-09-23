<template lang="html">
  <div>
    <vue-router />
    <navbar></navbar>
    <div class="content">
      <div class="search-container">
        <input type="text" placeholder="Search..." />
        <div class="search"></div>
      </div>
      <div class="post-container">
        <ul class="post">
          <li
            v-for="postItem in postItems"
            :class="postItem.Class"
            :key="postItem.id"
          >
            <span>
              <a href>{{ postItem.Title }}</a>
            </span>
          </li>
        </ul>
      </div>
    </div>
  </div>
</template>

<script>
import navbar from "./../components/navbar";
export default {
  name: "Home",
  components: {
    navbar
  },
  data() {
    return {
      postItems: [
        {
          Title: "Post 1",
          Class: "post-item home"
        },
        {
          Title: "Post 2",
          Class: "post-item portfolio"
        },
        {
          Title: "Post 3",
          Class: "post-item technology"
        },
        {
          Title: "Post 4",
          Class: "post-item knowledge"
        },
        {
          Title: "Post 5",
          Class: "post-item algorithms"
        },
        {
          Title: "Post 6",
          Class: "post-item books"
        }
      ]
    };
  }
};
</script>

<style lang="scss" scoped>
.search-container {
  position: absolute;
  margin-left: 25%;
  top: 5%;
  input {
    width: 150px;
    height: 35px;
    outline: none;
    border: none;
    background: rgba(180, 180, 180, 0.123);
    padding: 0 80px 0 20px;
    border-radius: 20px;
    font-size: 15px;
    &:hover {
      cursor: pointer;
    }
    &:focus {
      opacity: 1;
      cursor: text;
    }
    &::placeholder {
      opacity: 0.75;
    }
  }
}

.post-container {
  position: absolute;
  margin-top: 15%;
  margin-left: 25%;
}

.post {
  margin-top: 1%;
}

li {
  list-style-type: none;
  color: rgba(209, 46, 46, 0.5);
  font-size: 15px;
}

span {
  font-size: 18px;
  &::before {
    content: "";
    width: 8px;
    height: 8px;
    border-radius: 50%;
    float: left;
    margin: 10px 12px 0 0;
  }
}

a:link {
  text-decoration: none;
  color: rgb(20, 19, 19);
}

a:visited {
  text-decoration: none;
  color: rgb(20, 19, 19);
}

a {
  text-decoration: none;
}

.post-item {
  margin-top: 15px;
  font-size: 60%;
}

ul:hover li {
  opacity: 0.5;
}
ul li:hover {
  opacity: 1;
}

/* Smartphones (portrait and landscape) ----------- */
@media only screen and (min-width: 320px) and (max-width: 480px) {
  /* Styles */
}

/* Smartphones (landscape) ----------- */
@media only screen and (min-width: 321px) {
  /* Styles */
}

/* Smartphones (portrait) ----------- */
@media only screen and (max-width: 320px) {
  /* Styles */
}

/* iPads (portrait and landscape) ----------- */
@media only screen and (min-width: 768px) and (max-width: 1024px) {
  /* Styles */
}

/* iPads (landscape) ----------- */
@media only screen and (min-width: 768px) and (max-width: 1024px) and (orientation: landscape) {
  /* Styles */
}

/* iPads (portrait) ----------- */
@media only screen and (min-width: 768px) and (max-width: 1024px) and (orientation: portrait) {
  /* Styles */
}

/* Desktops and laptops ----------- */
@media only screen and (min-width: 1224px) {
  /* Styles */
}

/* Large screens ----------- */
@media only screen and (min-width: 1824px) {
  /* Styles */
}

/* iPhone 4 ----------- */
@media only screen and (-webkit-min-device-pixel-ratio: 1.5),
  only screen and (min-device-pixel-ratio: 1.5) {
  /* Styles */
}
</style>
