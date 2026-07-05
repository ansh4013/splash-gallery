* {
  margin: 0;
  padding: 0;
  box-sizing: border-box;
}

:root {
  --primary: #6366f1;
  --secondary: #ec4899;
  --success: #10b981;
  --danger: #ef4444;
  --dark: #1f2937;
  --light: #f9fafb;
  --text: #111827;
  --border: #e5e7eb;
}

body {
  font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
  background: var(--dark);
  color: var(--text);
}

/* ===== LOGIN SCREEN ===== */
.admin-container {
  min-height: 100vh;
  display: flex;
  align-items: center;
  justify-content: center;
}

.screen {
  display: none;
  width: 100%;
  animation: fadeIn 0.3s ease-in;
}

.screen.active {
  display: block;
}

@keyframes fadeIn {
  from { opacity: 0; transform: translateY(10px); }
  to { opacity: 1; transform: translateY(0); }
}

.login-box {
  background: white;
  padding: 3rem;
  border-radius: 1rem;
  box-shadow: 0 10px 40px rgba(0,0,0,0.2);
  max-width: 400px;
  width: 100%;
  text-align: center;
}

.login-box h1 {
  margin-bottom: 2rem;
  color: var(--primary);
  font-size: 2rem;
}

.login-box input {
  width: 100%;
  padding: 0.75rem;
  margin-bottom: 1rem;
  border: 1px solid var(--border);
  border-radius: 0.5rem;
  font-size: 1rem;
}

.btn-login {
  width: 100%;
  padding: 0.75rem;
  background: var(--primary);
  color: white;
  border: none;
  border-radius: 0.5rem;
  font-size: 1rem;
  font-weight: 600;
  cursor: pointer;
  transition: background 0.3s;
}

.btn-login:hover {
  background: #4f46e5;
}

.hint {
  margin-top: 1rem;
  color: #666;
  font-size: 0.9rem;
}

.hint code {
  background: var(--light);
  padding: 0.2rem 0.4rem;
  border-radius: 0.3rem;
  font-family: monospace;
}

/* ===== DASHBOARD ===== */
.admin-nav {
  background: white;
  padding: 1.5rem 2rem;
  display: flex;
  justify-content: space-between;
  align-items: center;
  box-shadow: 0 2px 10px rgba(0,0,0,0.1);
  margin-bottom: 2rem;
}

.admin-nav h2 {
  color: var(--primary);
  margin: 0;
}

.btn-logout {
  padding: 0.5rem 1.5rem;
  background: var(--danger);
  color: white;
  border: none;
  border-radius: 0.5rem;
  cursor: pointer;
  font-weight: 600;
  transition: background 0.3s;
}

.btn-logout:hover {
  background: #dc2626;
}

.admin-content {
  max-width: 1000px;
  margin: 0 auto;
  padding: 0 2rem 2rem;
}

/* ===== FORM SECTION ===== */
.section {
  background: white;
  padding: 2rem;
  border-radius: 1rem;
  margin-bottom: 2rem;
  box-shadow: 0 2px 10px rgba(0,0,0,0.1);
}

.section h3 {
  color: var(--primary);
  margin-bottom: 1.5rem;
  font-size: 1.5rem;
}

.art-form {
  display: grid;
  gap: 1.5rem;
}

.form-group {
  display: flex;
  flex-direction: column;
}

.form-group label {
  margin-bottom: 0.5rem;
  font-weight: 600;
  color: var(--text);
}

.form-group input,
.form-group textarea,
.form-group select {
  padding: 0.75rem;
  border: 1px solid var(--border);
  border-radius: 0.5rem;
  font-size: 1rem;
  font-family: inherit;
}

.form-group input:focus,
.form-group textarea:focus,
.form-group select:focus {
  outline: none;
  border-color: var(--primary);
  box-shadow: 0 0 0 3px rgba(99,102,241,0.1);
}

/* ===== FILE INPUT STYLING ===== */
.file-input-wrapper {
  position: relative;
  margin-bottom: 1rem;
}

.file-input-wrapper input[type="file"] {
  display: none;
}

.file-label {
  display: flex;
  flex-direction: column;
  align-items: center;
  justify-content: center;
  padding: 2rem;
  border: 2px dashed var(--primary);
  border-radius: 0.5rem;
  cursor: pointer;
  background: var(--light);
  transition: all 0.3s;
  gap: 0.5rem;
}

.file-label:hover {
  background: rgba(99,102,241,0.05);
  border-color: #4f46e5;
}

.file-label.drag-over {
  background: rgba(99,102,241,0.1);
  border-color: #4f46e5;
}

.upload-icon {
  font-size: 2rem;
}

.upload-text {
  color: var(--text);
  font-weight: 600;
}

#fileInfo {
  display: block;
  margin-top: 0.5rem;
  color: #666;
  font-size: 0.9rem;
}

/* ===== IMAGE PREVIEW ===== */
.image-preview-container {
  position: relative;
  margin-top: 1rem;
  padding: 1rem;
  background: var(--light);
  border-radius: 0.5rem;
  border: 1px solid var(--border);
}

.image-preview-container img {
  max-width: 100%;
  max-height: 300px;
  border-radius: 0.5rem;
  display: block;
  margin: 0 auto;
}

.btn-remove-image {
  margin-top: 1rem;
  width: 100%;
  padding: 0.5rem;
  background: var(--danger);
  color: white;
  border: none;
  border-radius: 0.5rem;
  cursor: pointer;
  font-weight: 600;
  transition: background 0.3s;
}

.btn-remove-image:hover {
  background: #dc2626;
}

/* ===== SUBMIT BUTTON ===== */
.btn-submit {
  padding: 1rem;
  background: var(--success);
  color: white;
  border: none;
  border-radius: 0.5rem;
  font-size: 1rem;
  font-weight: 600;
  cursor: pointer;
  transition: background 0.3s;
}

.btn-submit:hover {
  background: #059669;
}

/* ===== ARTWORKS LIST ===== */
.management-stats {
  margin-bottom: 1.5rem;
  padding: 1rem;
  background: var(--light);
  border-radius: 0.5rem;
  border-left: 4px solid var(--primary);
}

.artworks-list {
  display: grid;
  grid-template-columns: repeat(auto-fill, minmax(280px, 1fr));
  gap: 1.5rem;
}

.artwork-card {
  background: var(--light);
  border: 1px solid var(--border);
  border-radius: 0.75rem;
  overflow: hidden;
  transition: all 0.3s;
  box-shadow: 0 2px 5px rgba(0,0,0,0.05);
}

.artwork-card:hover {
  box-shadow: 0 8px 15px rgba(0,0,0,0.1);
  transform: translateY(-2px);
}

.artwork-image {
  width: 100%;
  height: 200px;
  object-fit: cover;
  background: #e5e7eb;
}

.artwork-info {
  padding: 1rem;
}

.artwork-title {
  font-size: 1.1rem;
  font-weight: 700;
  color: var(--text);
  margin-bottom: 0.25rem;
}

.artwork-artist {
  font-size: 0.9rem;
  color: #666;
  margin-bottom: 0.5rem;
}

.artwork-category {
  display: inline-block;
  background: var(--primary);
  color: white;
  padding: 0.25rem 0.75rem;
  border-radius: 0.25rem;
  font-size: 0.8rem;
  font-weight: 600;
  margin-bottom: 1rem;
}

.artwork-description {
  font-size: 0.85rem;
  color: #666;
  line-height: 1.4;
  margin-bottom: 1rem;
  max-height: 60px;
  overflow: hidden;
}

.artwork-actions {
  display: flex;
  gap: 0.5rem;
}

.btn-edit,
.btn-delete {
  flex: 1;
  padding: 0.5rem;
  border: none;
  border-radius: 0.5rem;
  font-size: 0.9rem;
  cursor: pointer;
  font-weight: 600;
  transition: all 0.3s;
}

.btn-edit {
  background: var(--primary);
  color: white;
}

.btn-edit:hover {
  background: #4f46e5;
}

.btn-delete {
  background: var(--danger);
  color: white;
}

.btn-delete:hover {
  background: #dc2626;
}

.empty-state {
  text-align: center;
  padding: 2rem;
  color: #999;
}

.empty-state-icon {
  font-size: 3rem;
  margin-bottom: 1rem;
}

/* ===== RESPONSIVE ===== */
@media (max-width: 768px) {
  .admin-nav {
    flex-direction: column;
    gap: 1rem;
    align-items: flex-start;
  }

  .admin-content {
    padding: 0 1rem 1rem;
  }

  .section {
    padding: 1rem;
  }

  .artworks-list {
    grid-template-columns: 1fr;
  }

  .file-label {
    padding: 1.5rem;
  }
}