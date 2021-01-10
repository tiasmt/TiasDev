<template>
  <div>
    <div v-if="loading" class="loader"><bounceloader></bounceloader></div>
    <div v-else>
      <div class="icon-border top-left" @click="$router.go(-1)">
        <span class="icon back"></span>
      </div>
      <img class="image" :src="imageSource" alt="" />
      <div class="title" v-if="title" v-html="title"></div>
      <div class="date" v-if="date" v-html="date"></div>
      <div class="content" v-if="body" v-html="body"></div>
      <div
        id="up-button"
        class="icon-border bottom-right"
        @click="ScrollToTop()"
      >
        <span class="icon up"></span>
      </div>
    </div>
  </div>
</template>

<script>
let marked = require("marked");
import bounceloader from "./../components/bounceloader";
export default {
  components: {
    bounceloader,
  },
  data() {
    return {
      backToTopButton: null,
    };
  },
  computed: {
    loading() {
      return this.$store.state.loading;
    },
    imageSource() {
      return this.$store.state.currentPost.imageURL;
    },
    title() {
      return marked(this.$store.state.currentPost.title);
    },
    date() {
      return marked(this.$store.state.currentPost.date);
    },
    body() {
      return marked(this.$store.state.currentPost.body);
    },
  },
  mounted() {
    this.backToTopButton = document.getElementById("up-button");
    window.addEventListener("scroll", this.HandleScroll);
  },
  destroyed() {
    window.removeEventListener("scroll", this.HandleScroll);
  },
  methods: {
    HandleScroll() {
      if (
        document.body.scrollTop > 20 ||
        document.documentElement.scrollTop > 20
      ) {
        this.backToTopButton.style.opacity = 1;
      } else {
        this.backToTopButton.style.opacity = 0;
      }
    },
    ScrollToTop() {
      document.body.scrollTop = 0; // For Safari
      document.documentElement.scrollTop = 0; // For Chrome, Firefox, IE and Opera
    },
  },
  created() {
    if (this.$store.state.title == null) {
      var url = window.location.href;
      var postId = url.charAt(url.length - 1);
      this.$store.dispatch("SetPost", {
        id: postId,
      });
    }
  },
};
</script>

<style lang="scss" scoped>
.image {
  float: left;
  margin-top: 5%;
  height: 150px;
  border-radius: 50%;
  margin-left: 10%;
}
.title {
  margin-top: 5%;
  margin-left: 5%;
  margin-bottom: 4%;
  text-transform: uppercase;
  float: left;
  font-size: 140%;
  color: rgb(53, 52, 52);
}

.date {
  float: right;
  position: relative;
  color: rgba(68, 65, 65, 0.72);
  font-size: 60%;
  margin-right: 15%;
  margin-top: 12%;
}

.content {
  margin-left: 10%;
  font-size: 65%;
  float: left;
}

.icon-border {
  background: rgba(43, 40, 40, 0.549);
  width: 50px;
  height: 50px;
  border-radius: 50%;
  transition: 500ms;
  position: sticky;
}

.top-left {
  margin-top: 2%;
  margin-left: 2%;
  position: fixed;
}

.back {
  mask: url("../assets/icons/left-arrow.svg");
  margin-left: 20%;
  margin-top: 20%;
}
.icon {
  display: inline-block;
  width: 30px;
  height: 30px;
  background: rgb(233, 228, 228);
  mask-size: cover;
}

.icon-border:hover {
  cursor: pointer;
  background: rgba(0, 0, 0, 0.85);
}

.bottom-right {
  position: fixed;
  bottom: 5%;
  right: 10%;
  opacity: 0;
  transition: 500ms;
}

.up {
  mask: url("../assets/icons/up-arrow.svg");
  margin-left: 20%;
  margin-top: 20%;
}

.loader {
  position: absolute;
  top: 50%;
  left: 50%;
}
</style>