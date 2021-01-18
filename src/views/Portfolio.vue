<template>
  <div class="container">
    <navbar></navbar>
    <div class="grid-container">
      <div class="grid-item">
        <div class="portfolio-item-text">WIP: Online Directory</div>
        <img src="./../assets/images/portfolio/mtdir.jpg" alt="" />
      </div>
      <div class="grid-item">
        <div class="portfolio-item-text">WIP: Online Directory</div>
        <img src="./../assets/images/portfolio/mtdir.jpg" alt="" />
      </div>
      <div class="grid-item">
        <div class="portfolio-item-text">WIP: Online Directory</div>
        <img src="./../assets/images/portfolio/mtdir.jpg" alt="" />
      </div>
      <div class="grid-item">
        <div class="portfolio-item-text">WIP: Online Directory</div>
        <img src="./../assets/images/portfolio/mtdir.jpg" alt="" />
      </div>
    </div>
  </div>
</template>

<script>
import navbar from "./../components/navbar";
export default {
  components: {
    navbar
  }
};
</script>

<style lang="scss">
.grid-container {
  position: absolute;
  display: grid;
  grid-template-columns: 50% 50%;
  grid-gap: 1% 1%;
  margin-top: 10%;
  margin-left: 35%;
}

.grid-item {
  overflow: hidden;
  border-radius: 5px;
}

.grid-item img {
  border-radius: 5px;
  min-height: 300px;
  opacity: 0.9;
  transition: transform 0.5s, opacity 0.5s;
  transform: scale(1.2);
  &:hover {
    transform: scale(1.1);
    cursor: pointer;
  }
}

.grid-item:hover .portfolio-item-text {
  color: #f80b0bc1;
}

.portfolio-item-text {
  color: #f80b0bc1;
  z-index: 999;
  position: relative;
  width: 100%;
  top: 40%;
  left: 15%;
  font-size: 85%;
}
</style>
